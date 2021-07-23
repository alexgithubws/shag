#include <iostream>
using namespace std;
void FillRand(int arr[], const int n);
void print(int arr[], const int n);
void main()
{
	setlocale(LC_ALL, " ");
	const int n = 10;
	int arr[n];
	FillRand(arr, n);
	print(arr, n);
	int evenn_cont = 0;
	int old_cont = 0;
	for (int i = 0; i < n; i++)
	{
		if (arr[i] % 2 == 0)evenn_cont++;
		else old_cont++;

	}
	cout << evenn_cont << endl;
	cout << old_cont << endl;

	int* arr_even = new int[evenn_cont];
	int* arr_old = new int[old_cont];
	for (int i = 0, j = 0 , k = 0; i < n; i++)
	{
		if (arr[i] % 2 == 0)
		{
			*(arr_even + j++) = *(arr + 1);
		}
		else
		{
			*(arr_old + k++) = *(arr + 1);
		}
	}
	print(arr_even, evenn_cont);
	print(arr_old, old_cont);
	delete[] arr_even;
	delete[] arr_old;
}



void FillRand(int arr[], const int n)
{
	for (int i = 0; i < n; i++)
	{
		arr[i] = rand() % 100;
	}
}
void print(int arr[], const int n)
{
	for (int i = 0; i < n; i++)
	{
		//cout << arr[i] << "\t";
		cout << *(arr+i) << "\t";
	}
	cout << endl;
}
