using System ;
class Book
{
  public string title;
  public string author;
  public double price;
  public double ISBN;
public Book() 
 {
   title="unknown";
   author="unknown";
   price=0.0;
   ISBN=0;
  }
  
  public Book(string title,string author)
  {
    this.title=title;
    this.author=author;
  }
  public Book(string title, string author,double price)
  {
    this.title=title;
    this.author=author;
    this.price=price;
    
  }
  public Book(string title, string author, double price, double ISBN)
  {
    this.title=title;
    this.author=author;
    this.price=price;
    this.ISBN=ISBN;
  }
  public void DisplayInfo()
  {
    Console.WriteLine("Title:"+title);
    Console.WriteLine("Author:"+author);
    Console.WriteLine("Price:$"+price);
    Console.WriteLine("ISBN:$"+ISBN);
  }
}
class program
{
  static void Main(string[]args)
  {
    Book book1=new Book("Misir Ali","Humayun Ahmed",210.0);
    Book book2=new Book("Noukadubi","Rabindranath Tagore",300.0);
    
    book1.DisplayInfo();
    book2.DisplayInfo();
  }
}
