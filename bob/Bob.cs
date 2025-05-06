public static class Bob
{
    public static string Response(string statement)
    {
        
        if(string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        //Trim the statement ir order to delete final an initial white spaces
        statement = statement.Trim();
        bool isYell = false;
        bool isQuestion = statement[^1] == '?';


        foreach (char ch in statement)
        {
            
            if(!char.IsWhiteSpace(ch) && !char.IsDigit(ch) && !char.IsPunctuation(ch) && !char.IsSymbol(ch))//avoiding numbers, white spaces, puntuation and symbols
            {
                //it's mayus?
                if(ch >= 'A' && ch <='Z') //If out of mayus range
                {
                    isYell = true;
                   
                }else
                {
                    isYell = false;
                    break;
                }
            }
        }
        
        if(isQuestion && isYell)
        {
            return "Calm down, I know what I'm doing!";

        }else if(isYell)
        {
            return "Whoa, chill out!";

        }else if(isQuestion)
        {
            return "Sure.";
        }else
        {
            return "Whatever.";
        }
    }
}