
#include <iostream>

using namespace std;

int main()
{
	int primeiroTermo;
	int razao;
	int numeroTermo;
	double totalPa;
	double totalPG;

	cout << "Digite o primeiro termo:";
	cin >> primeiroTermo;
	cout << "Digite a razao:";
	cin >> razao;
	cout << "Digite o numero total de termos:";
	cin >> numeroTermo;


	totalPa = primeiroTermo + (numeroTermo - 1) * razao;

	cout << "valor de PA = " << totalPa;


	totalPG = primeiroTermo * razao * (numeroTermo - 1);

	cout << "valor de PG é = " << totalPG;

	




}
