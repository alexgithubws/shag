#include<iostream>
using namespace std;

//��������� ��� ���ר�� ��������� ������� �� ����
void main()

{
    setlocale(LC_ALL, "Russian");
    float distancya, stoimost_poezdki, rashod_topliva, cena_benzina;
    cout << " \t\t��������� ��� ���ר�� ��������� ������� �� ����\n ";
    cout << "������� ���������� �� ���� � ����������: ";
    cin >> distancya;
    cout << "\n ";
    cout << "������� ������ ������� � ������ �� 100 ����������: ";
    cin >> rashod_topliva;
    cout << "\n ";
    cout << "������� ��������� ������� � ������� �� ����: ";
    cin >> cena_benzina;
    cout << "\n ";
    stoimost_poezdki = (((distancya * rashod_topliva) / 100) * cena_benzina) * 2;
    cout << "������� �� ���� �������� �: " << stoimost_poezdki << " ������ \n ";
    cout << "\n ";
    cout << "\t\t\t��� ���������� ��������� ������ enter" << endl;
    cin.get();

}