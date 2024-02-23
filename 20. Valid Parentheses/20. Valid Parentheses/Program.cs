// See https://aka.ms/new-console-template for more information
string s = "]";
Console.WriteLine(IsValid(s));
bool IsValid(string s)
{
    Stack<char> StackList = new();
    foreach (char item in s)
    {
        if (IsOpeningBrackets(item))
            StackList.Push(item);
        else if (IsCloseingBrackets(item))
        {
            if (StackList.Count > default(int) && StackList.Peek().Equals(OppositeBrackets(item)))
                StackList.Pop();
            else
                return false;
        }
        else return false;
    }
    return StackList.Count is 0;
}
bool IsOpeningBrackets(char c) => c.Equals('(') || c.Equals('[') || c.Equals('{');
bool IsCloseingBrackets(char c) => c.Equals(')') || c.Equals(']') || c.Equals('}');
char OppositeBrackets(char c)
{
    if (c.Equals(')')) return '(';
    else if (c.Equals(']')) return '[';
    else if (c.Equals('}')) return '{';
    else return new char();
}