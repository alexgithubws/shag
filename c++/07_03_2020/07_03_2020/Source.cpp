#include<iostream>
#include<ctime>
using namespace std;
void Pintss(arr[], int const SIZE )
{
	
	for (int i = 0; i < SIZE; i++)
	{
		arr[i] = rand() % 100;

		//std::cout << arr[i] << "\t";
	}
}

void main()
{

	/*
	type name (parametrs)
	
	*/
	int const SIZE = 5;
	int arr[SIZE];

	for (int i = 0; i < SIZE; i++)
	{
		arr[i] = rand() % 100;

		std::cout << arr[i] << "\t";
	}
	int k;
	std::cin >> k;
	int a = arr[0];
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






}