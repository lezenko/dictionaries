using System.Collections.Generic;
using dictionaries;
using System.Linq;

// People to add to Employees Object with values
Employees[] ppl = {
new Employees("Luke", 33, "Manager", 10),
new Employees("Amy", 29, "Baker", 9),
new Employees("Ronan", 4, "Student", 0)
};
// have to define key and string data type; Since were using Employees info, we declare that as data type.
Dictionary<string, Employees> empDir = new Dictionary<string, Employees>();

// Add the employees to the Dictionary
foreach (Employees emp in ppl)
{
    empDir.Add(emp.Role, emp);
}
//set a variable with data type employees to query the value and the write it to console.
Employees test = empDir["Baker"];
Console.WriteLine(test.Name);

string findit = "Manager";
if (empDir.ContainsKey(findit))
{
    Employees person = (Employees)empDir[findit];
    Console.WriteLine("{0} -- {1} -- {2} -- £{3}", person.Name, person.Age, person.Role, person.salaray );
}


// a try method (similar to try parse)
Employees tester = null;
if (empDir.TryGetValue("Student", out tester))
{
    Console.WriteLine("{0} -- {1} -- {2} -- £{3}", tester.Name, tester.Age, tester.Role, tester.salaray);
} else
{
    Console.WriteLine("Could not find user with such value");
}

//iterates through the key & values in empdir writing the result.
for (int i = 0; i < empDir.Count; i++) { 
KeyValuePair<string, Employees> watta = empDir.ElementAt(i);
    Console.WriteLine(watta.Key, watta.Value);
    Console.WriteLine("--------------");
    //once again setting a temporary employee in assigning the Key Value pair and obtaining the data.
    Employees wanker = watta.Value;
    Console.WriteLine("{0} -- {1} -- £{2}",wanker.Name,wanker.Age, wanker.salaray);
}