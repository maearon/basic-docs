import java.awt.*;  
import java.awt.event.*;  
 
public class MyCalculator extends Frame  
{  
  
public boolean setClear=true;  
double number, memValue;  
char op;  
  
String digitButtonText[] = {"7", "8", "9", "4", "5", "6", "1", "2", "3", "+/-", "0", "." }; 
String operatorButtonText[] = {"/", "*", "-", "+", "="};    
String specialButtonText[] = {"CE", "C", "Backspc" };  
  
MyDigitButton digitButton[]=new MyDigitButton[digitButtonText.length];  
MyOperatorButton operatorButton[]=new MyOperatorButton[operatorButtonText.length];    
MySpecialButton specialButton[]=new MySpecialButton[specialButtonText.length];  
  
Label displayLabel=new Label("0",Label.RIGHT);   
  
final int FRAME_WIDTH=337,FRAME_HEIGHT=542;  
final int HEIGHT=50, WIDTH=75, H_SPACE=3,V_SPACE=3;  
final int TOPX=15, TOPY=65;  
/*
H_SPACE: khoang cach giua cac nut chieu ngang
V_SPACE: khoang cach giua cac nut chieu doc

HEIGHT: chieu cao nut
WIDTH: chieu rong nut

TOPX :khoang cach le trai
TOPY :khoang cach le tren

*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
MyCalculator(String frameText)//constructor  
{  
super(frameText);  
  
int tempX=TOPX, y=TOPY+37;  
displayLabel.setBounds(tempX,y,FRAME_WIDTH-2*TOPX,3*HEIGHT/2);// o ket qua 
displayLabel.setBackground(new Color(31,31,31));
displayLabel.setFont(new Font("SANS_SERIF", Font.TYPE1_FONT, 47));   
displayLabel.setForeground(Color.WHITE);  
add(displayLabel);  


int digitX=TOPX;  
int digitY=TOPY+4*(HEIGHT+V_SPACE)+43; 

  
//set Co-ordinates for Special Buttons  
 
tempX=TOPX; 
y=digitY-(HEIGHT+V_SPACE);  
for(int i=0;i<specialButton.length;i++)  
{  
specialButton[i]=new MySpecialButton(tempX,y,WIDTH,HEIGHT,specialButtonText[i], this);  
specialButton[i].setForeground(Color.WHITE);  
specialButton[i].setBackground(new Color(19,19,19));
tempX+=WIDTH+H_SPACE; 
}  
  
//set Co-ordinates for Digit Buttons  
 
tempX=digitX;  
y=digitY;  
for(int i=0;i<digitButton.length;i++)  
{  
digitButton[i]=new MyDigitButton(tempX,y,WIDTH,HEIGHT,digitButtonText[i], this);  
digitButton[i].setForeground(Color.WHITE); 
digitButton[i].setBackground(new Color(6,6,6)); 
tempX+=WIDTH+H_SPACE;  
if((i+1)%3==0){tempX=digitX; y+=HEIGHT+V_SPACE;}  
}  
  
//set Co-ordinates for Operator Buttons  
int opsX=digitX+2*(WIDTH+H_SPACE);  
int opsY=digitY-(HEIGHT+V_SPACE);  
tempX=opsX;  y=opsY;  
for(int i=0;i<operatorButton.length;i++)  
{  
tempX+=WIDTH+H_SPACE;  
operatorButton[i]=new MyOperatorButton(tempX,y,WIDTH,HEIGHT,operatorButtonText[i], this);  
operatorButton[i].setForeground(Color.WHITE);  
operatorButton[i].setBackground(new Color(19,19,19));
if((i+1)%1==0){tempX=opsX; y+=HEIGHT+V_SPACE;}  
}  
  
addWindowListener(new WindowAdapter()  
{  
public void windowClosing(WindowEvent ev)  
{System.exit(0);}  
});  
  
setLayout(null);  
setSize(FRAME_WIDTH,FRAME_HEIGHT);  
setVisible(true);  
setBackground(new Color(31,31,31)); 
}  
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
static String getFormattedText(double temp)  
{  
String resText=""+temp;  
if(resText.lastIndexOf(".0")>0)  
    resText=resText.substring(0,resText.length()-2);  
return resText;  
}  
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   
public static void main(String []args)  
{  
new MyCalculator("Calculator"); 
}  
}  
