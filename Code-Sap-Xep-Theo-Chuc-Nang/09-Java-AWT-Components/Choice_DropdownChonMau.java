import java.awt.*;
class Choicetest extends Frame
{
	Label l1 =new Label("Checkboxs");
	Choice colors=new Choice();
	public Choicetest(String title)
	{
		super(title);
		setLayout(new FlowLayout());
		add(l1);
		colors.addItem("White");
		colors.addItem("Red");
		colors.addItem("Orange");
		colors.addItem("Green");
		colors.addItem("Yellow");
		colors.addItem("Blue");
		colors.addItem("Black");
		add(colors);
	}
	public static void main(String args[])
	{
		Choicetest t=new Choicetest("Choice list");
		t.setSize(300,200);
		t.show();
	}
}