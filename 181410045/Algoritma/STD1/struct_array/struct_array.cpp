#include <iostream>
#include <string>
#include <sstream>
#define awalan using namespace std

awalan;

/* buat struktur disini buat jadi satu semua */
struct menu_t 
{
	string makanan;
	int harga;
} menus[3];

/* buat print didalem */
void printfood(menu_t food);

int main()
{
	string mystr;
	int n;
		for (n=0; n<3; n++) 
		{
			cout << "Masukan Nama Makanan: ";
			//ambil yg udah diisi di variable / memori ke sini
			getline (cin, menus[n].makanan);
			cout << "Masukan Harga:Rp. ";
			//ini juga sama
			getline (cin,mystr);
			stringstream(mystr) >> menus[n].harga;
		}

	cout << "\nAnda telah memasukan Menu hidangan dibawah ini:\n";
		for (n=0; n<3; n++)
			//tarik semua yg diatas kesini
			printfood(menus[n]);

return 0;

}


//deklarasi buat ambilnya disini
void printfood(menu_t food)
{
	cout << food.makanan << "\t";
	cout << "Rp. " << food.harga << ",- \n";
}