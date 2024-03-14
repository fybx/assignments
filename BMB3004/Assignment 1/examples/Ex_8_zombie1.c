#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

int main ( void ) {

	if(fork())  {
		printf("Running parent, pid : %i\n",getpid());
		while(1);
	} else  {
		printf("Terminating child, pid : %i\n", getpid());
		exit(0);
	}

	exit (0);
}
