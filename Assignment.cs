/*
Question : https://docs.google.com/document/d/1MlXSUf_Bo2kynF3y0cFcsIY3C3VKwpxAKH2HiDTSrdk/edit?usp=sharing
*/
using System;
class Student{
	String Name;
	private int _marks;
	public Student(string name){
		Name = name;
	}
	public void setMarks(int num){
		if(num<0 || num>100){
			Console.WriteLine("Invalid Marks");
		}
		else{
			_marks = num;
		}
	}
	public int Display(){
		return _marks;
	}
}
class Assignment{
	public static void Main(string[] args){
		Student stu1 = new Student("Nishant");
		stu1.setMarks(-1);
		stu1.setMarks(100);
		Console.WriteLine(stu1.Display());
	}
}