public sealed class Singleton3 {  
    Singleton3() {}  
    private static readonly object lock = new object();  
    private static Singleton3 instance = null;  
    public static Singleton3 Instance {  
        get {  
            if (instance == null) {  
                lock(lock) {  
                    if (instance == null) {  
                        instance = new Singleton3();  
                    }  
                }  
            }  
            return instance;  
        }  
    }  
} 