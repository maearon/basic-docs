/*
sap xep chon moi day quet khi tang i cho so nho nhat day do dua len dau day
*/
#include<iostream>
#include<conio.h>
using namespace std;
int main()
{
int a[50],n,i,j,tg,min,cs;
cout << "n=";cin >> n;
/*Nhap mang*/
for(i=0;i<n;i++){cout<<"a["<<i+1<<"]=";cin >> a[i];}
/*Sap xep phuong phap chen*/
for (i=0;i<n-1;i++)
{
min=a[i];
for (j=i+1;j<n;j++) if (a[j]<min) {min=a[j];cs=j; }
tg=a[i];a[i]=min;a[cs]=tg;
}
/*-------------------*/
/*Xuat mang*/
for(i=0;i<n;i++)cout<<a[i]<<"\t";
getch();
}
