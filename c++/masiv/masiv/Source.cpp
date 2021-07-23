#include<iostream>
#include<ctime>
#define SDVIG_MASIVA
#define SS_DVA
#define SS_HEX

void main()
{
	setlocale(LC_ALL, "Rus");
	srand(time(NULL));
	/*Найти минимальное и максимальное значение в массиве;*/
	//int const SIZE = 10;
	int const SIZE = 5;
	int arr[SIZE];
	int max, min;

	for (int i = 0; i < SIZE; i++)
	{
		arr[i] = rand() % 100;

		std::cout << arr[i] << "\t";
	}
	max = arr[0];
	min = arr[0];
	for (int i = 1; i < SIZE; i++)
	{

		if (max > arr[i])
		{
			max = arr[i];
		}
		if (min < arr[i])
		{
			min = arr[i];
		}
		//std::cout << arr[i] << "\t";
	}
	std::cout << std::endl;
	std::cout << max << "\n" << min << std::endl;
#ifdef SDVIG_MASIVA
	/*Сдвинуть массив на заданное число элементов влево или вправо;*/
	int k, a, b;
	std::cin >> k;
	a = arr[0];
	//Сдвинуть массив влево
	for (int i = 0; i < k; i++)
	{


		for (int i = 0; i < SIZE; i++)
		{
			arr[i] = arr[i + 1];
		}
		arr[SIZE - 1] = a;
		for (int i = 0; i < SIZE; i++)
		{
			std::cout << arr[i] << "\t";
		}
	}
	std::cout << std::endl;
	//Сдвинуть массив вправо
	b = arr[0];
	for (int i = 0; i < k; i++)
	{


		for (int j = 1; j < SIZE; j++)
		{
			arr[j - 1] = arr[j];
		}
		arr[SIZE - 1] = b;
		for (int j = 0; j < SIZE; j++)
		{
			std::cout << arr[j] << "\t";
		}
	}
	std::cout << std::endl;

#endif // SDVIG_MASIVA

#ifdef SS_DVA
	typedef int Nubetype;
	Nubetype dex;
	const int razmer = sizeof(Nubetype) * 8;
	int bin[razmer] = {};
	std::cin >> dex;
	int i = 0;
	while (dex > 0)
	{
		bin[i] = dex % 2;
		dex /= 2;
		i++;

	}
	for (int i = razmer - 1; i >= 0; i--)
	{
		std::cout << bin[i];
		if (i % 4 == 0) { std::cout << " "; }
		if (i % 8 == 0) { std::cout << " "; }
	}
	std::cout << std::endl;
#endif // SS_DVA

#ifdef SS_HEX
	
	typedef int IntergralT;
	IntergralT hex;

	const short razmer1 = sizeof(IntergralT) * 8;
	char bin1[razmer1] = {};
	std::cin >> hex;


	int j = 0;
	while (hex > 0)
	{
		{
			bin1[j] = hex % 16;
			hex /= 16;

			char ch;
			ch = j;
			switch (bin1[j])
			{
			case 0:
				ch = '0';
				break;
			case 1:
				ch = '1';
				break;
			case 2:
				ch = '2';
				break;
			case 3:
				ch = '3';
				break;
			case 4:
				ch = '4';
				break;
			case 5:
				ch = '5';
				break;
			case 6:
				ch = '6';
				break;
			case 7:
				ch = '7';
				break;
			case 8:
				ch = '8';
				break;
			case 9:
				ch = '9';
				break;
			case 10:
				ch = 'A';
				break;

			case 11:
				ch = 'B';
				break;

			case 12:
				ch = 'C';
				break;

			case 13:
				ch = 'D';
				break;

			case 14:
				ch = 'E';
				break;

			case 15:
				ch = 'F';
				break;

			default:
				ch = hex + 48;
				break;
			}
			ch = hex;
			j++;
		}
		for (int j = razmer1 - 1; j >= 0; j--)
		{
			std::cout << bin1[j];
		}

	}
	
#endif // SS_HEX














}
















