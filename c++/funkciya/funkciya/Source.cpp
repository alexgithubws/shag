#include<iostream>
void fillrand(int arr[], const int SIZE);
void minValueIn(int arr[], const int SIZE , int min);
void maxValueIn(int arr[], const int SIZE , int max);
void avg(int arr[], const int SIZE , int sum);
void Sort(int arr[], const int SIZE);
void print(int arr[], const int SIZE);
void main()
{
	setlocale(LC_ALL, " ");

	int const SIZE = 5;
	int arr[SIZE];
	int max, min ,sum;
	fillrand(arr, SIZE);
	max = arr[0];
	min = arr[0];
	minValueIn(arr, SIZE, min);
	minValueIn(arr, SIZE, max);
	sum = 0;
	avg(arr, SIZE, sum);
	Sort(arr, SIZE);
	print(arr, SIZE);
}
void fillrand(int arr[], const int SIZE)
{
	for (int i = 0; i < SIZE; i++)
	{
		arr[i] = rand() % 100;

		std::cout << arr[i] << "\t";
	}
}
void minValueIn(int arr[], const int SIZE , int min)
{

	for (int i = 0; i < SIZE; i++)
	{

		if (min < arr[i])
		{
			min = arr[i];
		}

	}
	std::cout << std::endl;
	std::cout << min << std::endl;
}
void maxValueIn(int arr[], const int SIZE, int max)
{
	for (int i = 0; i < SIZE; i++) 
	{

		if (max > arr[i])
		{
			max = arr[i];
		}

	}
	std::cout << std::endl;
	std::cout << max << std::endl;
}
void avg(int arr[], const int SIZE, int sum)
{
	for (int i = 0; i < SIZE; i++)
	{
		sum += arr[i]; 
	}
	std::cout << sum / SIZE << "\t";
}

void Sort(int arr[], const int SIZE)
{

	for (int i = 0; i < SIZE; i++)
	{
		for (int j = i + 1; j < SIZE; j++) {
			if (arr[j] < arr[i])
			{
				int bufer = arr[i];
				arr[i] = arr[j];
				arr[j] = bufer;
			}
		}
		
	}
	
}
void print(int arr[], const int SIZE)
{
	for (int i = 0; i < SIZE; i++)
	{
		std::cout << arr[i]<< "\t";
	}
	std::cout << std::endl;
}
