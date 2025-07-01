
using System.Collections.Generic;

Dictionary<int,string> st=new Dictionary<int,string>();

st.Add(1,"pawar");
st.Add(2, "aaa");
st.Add(3, "bb");

//foreach (var i in st)
foreach (dynamic i in st) 
{ 

    Console.WriteLine(i);
}
Console.WriteLine();

bool b1 =st.ContainsKey(1);
Console.WriteLine(b1);  

bool b2 =st.ContainsValue("pawar");
Console.WriteLine(b2);




Console.Read();