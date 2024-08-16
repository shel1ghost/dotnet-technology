using System;

class IndexerExample{
    private string[] names = new string[4];
    public string this [int i]{
        get { return names[i]; }
        set { names[i] = value; }
    }
}

class Program{
    static void Main(){
        IndexerExample ex = new IndexerExample();
        ex[0] = "Babi";
        ex[1] = "Astra";
        ex[2] = "Shellghost";
        ex[3] = "Miss Programmer";
        for(int i=0; i<4; i++){
            Console.WriteLine(ex[i]);
        }
    }
}