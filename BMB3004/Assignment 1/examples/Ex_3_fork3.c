#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

int main ( void )  {

	printf("(%i) Parent does something...\n", getpid());

	if(fork())  {
		printf("(%i) Parent do completely different stuff\n",getpid());
	} else {
		printf("(%i) Child can do some stuff\n",getpid());
	}


	exit(0);
}
