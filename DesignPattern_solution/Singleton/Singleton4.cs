public sealed class Singleton4    
{    
    private static readonly Singleton4 instance = new Singleton4();    
    static Singleton4()    
    {    
    }    
    private Singleton4()    
    {    
    }    
    public static Singleton4 Instance    
    {    
        get    
        {    
            return instance;    
        }    
    }    
}   