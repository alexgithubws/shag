#include<iostream>
void Fillran(int arr[], const int n);
void Fillran(double arr[], const int n);
void Print(int arr[], const int n);
void Sort(int arr[], const int n);

void main()
{
	setlocale(LC_ALL, "  ");

	const int n = 5;
	int arr[n];

	Print(arr, n);
	Fillran(arr, n);
	Sort(arr, n);
	double crr[n];
	Fillran(arr, n);
}

void Print(int arr[], const int n)
{
	for (int i = 0; i < n; i++)
	{
		std::cout << arr[i] << "\t";
		
	}
	std::cout << std::endl;
}
void Fillran(int arr[], const int n)
{
	for (int i = 0; i < n; i++)
	{
		arr[i] = rand() % 100;
	}
	
}
void Fillran(double arr[], const int n)
{
	for (int i = 0; i < n; i++)
	{
		arr[i] = rand() % 100;
		arr[i] /=10;
	}

}
void Sort(int arr[], const int n)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = i + 1; j < n; j++) {
			if (arr[j] < arr[i])
			{
				int bufer;
				arr[i] = arr[j];
				arr[j] = bufer;
			}
		}
	}
} 
