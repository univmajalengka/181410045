//tes_doang
#include <iostream>
/* definisikan awalan sebagai namespace standar */
#define awalan using namespace std
//merubah cout menjadi command
#define command cout

awalan;

int main()
{
	int a[3][2], b[3][2], c[3][2]; //deklarasikan dulu


	command<<"Masukan Array #1 (isikan 6 angka):"<<endl;
	for (int i = 0; i < 3; i++) //array 1, baris 1 di matriks
	{
		for (int x = 0; x < 2; x++) //array 1, baris 2 di matriks
		{
			cin>>a[i][x];
		}
	}

	command<<"Masukan Array #2 (isikan 6 angka):"<<endl;
	for (int i = 0; i < 3; i++) //array 2, baris 1 di matriks
	{
		for (int x = 0; x < 2; x++) //array 2, baris 2 di matriks
		{
			cin>>b[i][x];
		}
	}

	//proseskan disini
	for (int i = 0; i < 3; i++)
	{
		for (int x = 0; x < 2; x++)
		{
			c[i][x] = a[i][x] + b[i][x];
		}
	}

	//save the world
	command<<"Keluaran: "<<endl;
	for (int i = 0; i < 3; i++)
	{
		for (int x = 0; x < 2; x++)
		{
			cout<<c[i][x]<<"|";
		}
	command<<"\n";
	}
	return 0;
}