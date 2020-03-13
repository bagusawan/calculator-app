using System;

public class Program
{
	private double tambah (double a, double b){

	return ( a + b );
	}

	private double kurang (double a, double b ){
	return ( a - b );
	}

	private double kali (double a, double b ){
	return ( a * b );
	}

	private double bagi (double a, double b ){
	return (a / b );
	}

	public void Main()
	{

		double angka1, angka2;
		char pilihan;
		Console.WriteLine(" ----------------------------------------");
		Console.WriteLine(" |	PROGRAM KALKULATOR 	");
		Console.WriteLine(" ----------------------------------------");
		Console.WriteLine("\n");
		Console.WriteLine(" ----------------------------------------");
		Console.WriteLine(" |	     MASUKAN PILIHAN		");
		Console.WriteLine(" ----------------------------------------");
		Console.WriteLine(" |					");
		Console.WriteLine(" |	(A) Tambah  (B) Kurang	");
		Console.WriteLine(" |	(C) Kali	(D) Bagi	");
		Console.WriteLine(" |					");
		Console.WriteLine(" ----------------------------------------");
		Console.WriteLine(" Masukan Pilihan		: ");
		pilihan = Convert.ToChar(Console.ReadLine());
		Console.WriteLine("\n");

		if ( pilihan == 'A' || pilihan == 'a' ) {
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" |	     Masukan Angka		");
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" |					");
			Console.WriteLine(" | Masukan Bilangan pertama : ");
			angka1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(" | Masukan Bilangan kedua : ");
			angka2 = Convert.ToDouble(Console.ReadLine());;
			Console.WriteLine(" |					");
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" | Hasilnya Adalah : "+tambah(angka1,angka2)+"");
			Console.WriteLine(" ----------------------------------------");

		}

		else if ( pilihan == 'B' || pilihan == 'b' ) {
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" |	     Masukan Angka		");
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" |					");
			Console.WriteLine(" | Masukan Bilangan pertama : ");
			angka1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(" | Masukan Bilangan kedua : ");
			angka2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(" |					");
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" | Hasilnya Adalah : "+kurang(angka1,angka2)+"");
			Console.WriteLine(" ----------------------------------------");
		}

		else if ( pilihan == 'c' || pilihan == 'C' ) {
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" |	     Masukan Angka		");
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" |					");
			Console.WriteLine(" | Masukan Bilangan pertama : ");
			angka1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(" | Masukan Bilangan kedua : ");
			angka2 =  Convert.ToDouble(Console.ReadLine());;
			Console.WriteLine(" |					");
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" | Hasilnya Adalah : "+kali(angka1,angka2)+"");
			Console.WriteLine(" ----------------------------------------");

		}

		else if ( pilihan == 'D' || pilihan == 'd' ) {
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" |	     Masukan Angka		");
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" |					");
			Console.WriteLine(" | Masukan Bilangan pertama : ");
			angka1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine(" | Masukan Bilangan kedua : ");
			angka2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(" |					|");
			Console.WriteLine(" ----------------------------------------");
			Console.WriteLine(" | Hasilnya Adalah : "+bagi(angka1,angka2)+"");
			Console.WriteLine(" ----------------------------------------");
		}



	}
} 