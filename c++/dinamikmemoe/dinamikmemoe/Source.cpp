#include<iostream>
using namespace std;
void FillRand(int arr[], const int n);
void print(int arr[], const int n);
void main()
{
	setlocale(LC_ALL, " ");
	int n;
		cin >> n;
		int* arr = new int[n];



		FillRand(arr, n);
		print(arr, n);
		delete[] arr;
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
		cout << arr[i] << "\t";
	}
	cout << endl;
}