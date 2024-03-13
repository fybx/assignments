#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

int main ( void )  {

	printf("Parent does stuff and then calls fork...\n");
	
	if(fork())  {
		printf("... parent do something completely different\n");
	} else  {
		printf("Child runs an executable...\n");
		execl("/bin/ls","/bin/ls","-l","/etc/apache2/conf.d/",NULL);
	}

	exit(0);
}

