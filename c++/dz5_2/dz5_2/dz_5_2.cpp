#include<iostream>
#define ROMB

void main()
{
	setlocale(LC_ALL, "Rus");
	//PRYAMOUGOLNIK_PLUS_MINUS
	int n = 5;
	for (int i = 0; i < n; i++)
	{


		for (int j = 0; j < n ; j++)
		{
			if ((i+j)%2 == 0)
			{
				std::cout << "+";
			}
			else
			{
				std::cout << "-";
			}
		}
		
		std::cout << std::endl;
	}
	std::cout << std::endl;
	std::cout << "\t\t\tдля завершения программы нажите enter" << std::endl;
	std::cin.get();
#ifdef ROMB
	int rhombSize = 5;
	int px = n;
	int py = n;
	int ps = 1;
	int pz = n * 2 -1;
	for (int i = 1; i < n; i++)
	{
		for (int j = 1; j < n*2; j++)
		{
			if(j == px +1)
			{
				std::cout << "\\";
			}
			else if (j ==py)
				std::cout << "/";
			else
			{
				std::cout << " ";
			}
		}
		px++;
		py--;
		std::cout << std::endl;
	}
	for (int i = 1; i < n; i++)
	{
		for (int j = 1; j < n*2; j++)
		{
			if (j == ps +1)
			{
				std::cout << "\\";
			}
			else if (j == pz)
				std::cout << "/";
			else
			{
				std::cout << " ";
			}
		}
		ps++;
		pz--;
		std::cout << std::endl;
	}
	std::cout << std::endl;
	std::cout << "\t\t\tдля завершения программы нажите enter" << std::endl;
	std::cin.get();
#endif // ROMB





}