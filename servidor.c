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
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	// htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9092);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0)
		printf("Error en el Listen");
	
	// Atenderemos solo 5 peticione
	while(1)
	{
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		//sock_conn es el socket que usaremos para este cliente
		
		int desconectar = 0;
		while(!desconectar)
		{
			// Ahora recibimos su nombre, que dejamos en peticion
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			
			// Tenemos que a?adirle la marca de fin de string 
			// para que no escriba lo que hay despues en el peticioner
			peticion[ret]='\0';
			
			//Escribimos el nombre en la consola
			printf ("Se ha conectado: %s\n",peticion);
			
			char *p = strtok( peticion, "/");
			int codigo =  atoi (p);
			char nombre[20];
			if(codigo)
			{
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			}
			
			int n_chars = strlen(nombre);
			int chars_mitad;
			char* nombre_izq;
			char* nombre_der;
			switch (codigo)
			{
			case 1:
				sprintf (respuesta,"%d",strlen (nombre));
				break;
				
			case 2:
				if((nombre[0]=='M') || (nombre[0]=='S'))
				{
					strcpy (respuesta,"SI");
				}
				else
				{
					strcpy (respuesta,"NO");
				}
				break;
				
			case 3:
				p = strtok(NULL, "/");
				float altura = atof(p);
				if (altura >= 1.70)
				{
					sprintf(respuesta, "%f: eres alto", altura);
				}
				else sprintf(respuesta, "%f: eres bajo", altura);
				break;
			case 4:
				// detectar si el nombre tiene un numero par o impar de caracteres
				if(n_chars % 2) // Es impar
				{
					chars_mitad = (n_chars - 1) / 2;
				}
				else // Es par
				{
					chars_mitad = n_chars / 2;
				}
				
				// pasamos el nombre a upper case
				for (int i = 0; i < n_chars; i++)
				{
					nombre[i] = toupper(nombre[i]);
				}
				
				// pedimos memoria para las strings (inc. el null terminator)
				nombre_izq = malloc(sizeof(char) * (chars_mitad + 1));
				nombre_der = malloc(sizeof(char) * (chars_mitad + 1));
				
				// copiamos las mitades de los nombres
				for(int i = 0; i < chars_mitad; i++)
				{
					nombre_izq[i] = nombre[i];
					nombre_der[i] = nombre[(n_chars - 1) - i];
				}
				
				// terminamos las strings para que strcmp funcione correctamente
				nombre_izq[chars_mitad] = '\0';
				nombre_der[chars_mitad] = '\0';
				
				if(!strcmp(nombre_izq, nombre_der))
				{
					sprintf(respuesta, "1/%s", nombre);
				}
				else
				{
					sprintf(respuesta, "0/%s", nombre);
				}	
				free(nombre_izq);
				free(nombre_der);				
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
