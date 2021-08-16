public sealed class Singleton2 {  
    Singleton2() {}  
    private static readonly object lock = new object();  
    private static Singleton2 instance = null;  
    public static Singleton2 Instance {  
        get {  
            lock(lock) {  
                if (instance == null) {  
                    instance = new Singleton2();  
                }  
                return instance;  
            }  
        }  
    }  
}  