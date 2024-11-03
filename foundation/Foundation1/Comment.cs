
// _namePerson :string 
// _text:string
// Comment:(namePerson: string, text: string)
// Display():string
//
class Comment
{
    private string _namePerson;
    private string _text;

    public Comment(string namePerson, string text)
    {
        _namePerson = namePerson;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_namePerson}, Text: {_text}");
    }
}



    