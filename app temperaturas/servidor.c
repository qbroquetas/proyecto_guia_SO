#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	
	// Fem el bind al port
	memset(&serv_adr, 0, sizeof(serv_adr)); // inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la maquina. 
	// htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9092);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0)
		printf("Error en el Listen");
	
	// Atenderemos peticiones indefinidamente
	while(1)
	{
		printf ("Escuchando\n");	
		
		//sock_conn es el socket que usaremos para este cliente
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");

		int desconectar = 0;
		while(!desconectar)
		{
			// Ahora recibimos el mensaje, que dejamos en peticion
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			
			// marcamos el final de string
			peticion[ret]='\0';
			
			char *p = strtok( peticion, "/");
			int codigo =  atoi(p); // sacamos el codigo del request
			float temp;
			
			// si existe, sacamos la temperatura
			if(codigo)
			{
				p = strtok( NULL, "/");
				temp = atof(p);
				printf ("Codigo: %d, temp: %f\n", codigo, temp);
			}
			
			switch (codigo)
			{
				
			// conversion a Celsius
			case 1:
				temp  = (temp - 32) / 1.8f;
				sprintf(respuesta, "%f", temp);
				break;
				
			// Conversion a Fahrenheit
			case 2:
				temp = temp * 1.8f + 32;
				sprintf(respuesta, "%f", temp);
				break;
				
			case 0:
				// Se acabo el servicio para este cliente
				desconectar = 1;
				break;
				
			default:
				printf("Error. codigo no reconocido.\n");
				break;
			}
			
			// Enviamos respuesta siempre que no se haya recibido peticion de desconectar
			if(codigo)
			{
				printf ("%s\n", respuesta);
				write (sock_conn, respuesta, strlen(respuesta));	
			}
		}
		close(sock_conn);
	}
}
