/*�������� ��������� ���������� ��������� �������, ��������� �� ���������� ��������
� ������ �� ���������� ������� � ���.*/
#include<iostream>

void main() 
{
	setlocale(LC_ALL, "Russian");
	double cena_tetradey;
	std::cout << "\t\t\t������� ���� ������� :" << std::endl;
	std::cin >> cena_tetradey;
	double cena_oblojka;
	std::cout << "\t\t\t������� ���� ������� :" << std::endl;
	std::cin >> cena_oblojka;
	int kolichestvo_komplekt;
	std::cout << "\t\t\t������� ���������� ���������� :" << std::endl;
	std::cin >> kolichestvo_komplekt;
	double stoimost_pokupki;
	stoimost_pokupki = (cena_tetradey + cena_oblojka) * kolichestvo_komplekt ;
	std::cout << "\t\t\t��������� ������� ���������� " << stoimost_pokupki << " ���." << std::endl;
	std::cout << "\n ";
	std::cout << "\t\t\t��� ���������� ��������� ������ enter" << std::endl;
	std::cin.get();

}