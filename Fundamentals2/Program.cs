// Three Basic Arrays
int[] IntArray = {1,2,3,4,5,6,7,8,9};

string[] StringArray = {"Tim", "Martin", "Nikki", "Sara"};

bool[] BoolArray = new bool[10];
for(int i = 0; i < BoolArray.Length; i++){
    if(i%2==0){
        BoolArray[i] = true;
    } else {
        BoolArray[i] = false;
    }
}

// List of Flavors
List<string> Flavors = new()
{
    "Vanilla",
    "Chocolate",
    "Moose Tracks",
    "Peanut Butter Cup",
    "Strawberry"
};
// Console.WriteLine(Flavors.Count);
// Console.WriteLine(Flavors[2]);
Flavors.RemoveAt(2);
// Console.WriteLine(Flavors.Count);

// User Dictionary
Dictionary<string, string> User = new();
foreach(string name in StringArray)
{
    Random RandomNum = new();
    User.Add(name, Flavors[RandomNum.Next(Flavors.Count)]);
}

foreach(KeyValuePair<string, string> OneUser in User)
{
    Console.WriteLine($"{OneUser.Key} likes {OneUser.Value}");
}