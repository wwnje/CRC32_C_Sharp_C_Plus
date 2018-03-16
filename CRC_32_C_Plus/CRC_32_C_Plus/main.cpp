#include <iostream>
using namespace std;

unsigned int GetCRC32_1(char *c, int len);
unsigned int GetCRC32_2(char *c, int len);

int main(int argc, const char * argv[])
{
	char msg[] = "Hello, World!";

	cout << GetCRC32_1(msg, strlen(msg)) << endl;
	cout << GetCRC32_2(msg, strlen(msg)) << endl;

	printf("%i", GetCRC32_1(msg, strlen(msg)));

	cin.get();
}