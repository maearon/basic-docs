/*
cho mot day gom n phan tu. hay sap xep day theo chieu tang dan 
sap xep tung phan tu cua day
bat dau tu phan tu dau tien
gia su can sap phan tu thu i ta tien hanh duyet lan luot qua tat ca cac phan tu dung sau no trong day
neu gap phan tu bnao nho hon thi doi cho
de doi cho ai cho aj ta su dung mot bien trung gian co cung kieu du lieu va gan mot trong hai gia tri ai hoac aj vao do
sau do gan gia tri con lai sang o vua gan vao trung gian. cuoi cung ta gan gia tri dang con chua trong trung gian vao o nho nay
*/
#include<iostream>
#include<conio.h>
using namespace std;
int main()
{
int a[50],n,i,j,tg;
cout << "n=";cin >> n;
for(i=0;i<n;i++){cout<<"a["<<i+1<<"]=";cin >> a[i];}
/*Sap xep noi bot*/
for (i=0;i<n-1;i++)
for (j=i+1;j<n;j++) if (a[i]>a[j]){tg=a[i];a[i]=a[j];a[j]=tg;}
/*-------------------*/
/*Xuat mang*/
for(i=0;i<n;i++)cout<<a[i]<<"\t";
getch();
}
/*
 Minh thay debug cua DevC++ khá hay va ton tai nguyen he thong. 
Truoc khi debug ban can F9 compile file nguon . 
Ðe debug ban de con tro vao phan dau tien trong ham main ().
O phan duoi cua cua so hien thi, ban chuyen sang Tab Debug, 
chon Run to cursor (Shift + F4), se xuat hien 1 dòng do trên file nguon the hien tien do chuong trinh chay den dau. 
Sau do ban nhan nút Next Step (F7) de chuong trinh chay sang buoc tiep theo. 
De theo doi bien nao ban chon Add watch (F4), nhap ten bien va Enter, giá tri cua bien can theo dõi se hien ra trong tab Debug ? 
phan khung ben trai. Muon bo theo doi mot bien ban chon bien do va chon Remove Watch.
Khi ban gui 1 ham, neu chon Next Step thi chuong trinh se thuc hien ham do (không debug hàm), 
con neu nhon Step into (Shift + F7) thi con tro debug se chuyen vao trong than ham duoc gui và tien hanh debug ham do.
Muon dung Debug ban chon Stop Execution (Ctrl + Alt + F12).
*/
