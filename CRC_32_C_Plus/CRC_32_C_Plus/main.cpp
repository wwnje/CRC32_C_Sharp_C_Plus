#include <iostream>
using namespace std;

unsigned int getcrc(char *c, int len);
unsigned int GetCRC32(char *c, int len);

int main(int argc, const char * argv[])
{
	char msg[] = "Hello, World233!";

	cout << getcrc(msg, strlen(msg)) << endl;
	cout << GetCRC32(msg, strlen(msg)) << endl;

	printf("%i", getcrc(msg, strlen(msg)));

	cin.get();
}