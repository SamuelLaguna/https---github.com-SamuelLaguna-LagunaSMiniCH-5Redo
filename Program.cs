//Samuel Laguna
//10-20-22
//We are to make a mad lib generator, Adding a play again feture and data validation
//Peer Review:


Console.Clear();
string noun1 = "";
string noun2 = "";
string noun3 = "";
string noun4 = "";
string adj1 = "";
string adj2 = "";
string verb1 = "";
string verb2 = "";
string lastWord = "";
string randomWord = "";
bool TryAgain = true;
bool end = false;
while(TryAgain){

Console.WriteLine("Today we are going to make up a story");
Console.WriteLine("Please enter a noun");
bool n1 = false;
while(!n1)
{
noun1 = Console.ReadLine();
bool checkN1 = noun1.All(Char.IsLetter);
if(checkN1 == false)
{
    Console.WriteLine("Not a word");
    n1 = false;
}else
{
    n1 = true;
}
}
    bool n2 = false;
while(!n2){
Console.WriteLine("Please enter a second noun");
noun2 = Console.ReadLine();
bool checkN2 = noun2.All(Char.IsLetter);
if(checkN2 == false){
Console.WriteLine("This is not a word");
   n2 = false;
   
}else{
   n2 = true;
}
}
bool a1 = false;
while(!a1){
Console.WriteLine("Please enter a adjective");
adj1 = Console.ReadLine();
bool checka1 = adj1.All(Char.IsLetter);
 if(checka1 == false)
 {
    Console.WriteLine("This is not a word");
    a1 = false;

 }else{
    a1 = true;
 }
}
bool a2 = false;
while(!a2){
Console.WriteLine("Please enter a second adj");
adj2 = Console.ReadLine();
bool checka2 = adj2.All(Char.IsLetter);
if(checka2 == false)
{
  Console.WriteLine("This is not a word");
  a2 = false;
}else
{
   a2 = true;
}

}
bool v1 = false;
while(!v1){
Console.WriteLine("Please enter a verb");
verb1 = Console.ReadLine();
bool checkv1 = verb1.All(Char.IsLetter);
if(checkv1 == false)
{
    Console.WriteLine("this is not word");
     v1 = false;
}else
{
    v1 = true;
}
}
bool v2 = false;
while(!v2){
Console.WriteLine("Please enter a second verb ");
verb2 = Console.ReadLine();
bool checkv2 = verb2.All(Char.IsLetter);
if(checkv2 == false)
{
    Console.WriteLine("This is not word");
    v2 = false;
}else
{
    v2 = true;
}
}
bool n3 = false;
while(!n3){
Console.WriteLine("Please enter a third noun");
noun3 = Console.ReadLine();
bool checkn3 = noun3.All(Char.IsLetter);
if(checkn3 == false)
{
    Console.WriteLine("This is not word");
    n3 = false;
}else
{
    n3 = true;
}

}
bool n4 = false;
while(!n4){
Console.WriteLine("Please enter a fourth noun");
noun4 = Console.ReadLine();
bool checkn4 = noun4.All(Char.IsLetter);
if(checkn4 == false)
{
    Console.WriteLine("This is not a word");
    n4 = false;
}else
{
    n4 = true;
}
}
bool rw = false;
while(!rw){
Console.WriteLine("Please enter a ramdome word");
randomWord = Console.ReadLine();
bool checkrw = randomWord.All(Char.IsLetter);
if(checkrw == false)
{
    Console.WriteLine("This is not a word");
    rw = false;
}else
{
    rw = true;
}
}
bool lw = false;
while(!lw){
Console.WriteLine("Please enter a last word");
lastWord = Console.ReadLine();
bool checklw = lastWord.All(Char.IsLetter);
if(checklw == false)
{
    Console.WriteLine("This Is not a word");
    lw = false;
}else
{
    lw = true;
}
}


Console.WriteLine("here is your final story...");
string story = "\" I know it, \" returned the " + noun1 + "  a " + verb2 + " tear ran from his eye with the tip"
+ " of his " + noun2 + " \"it is my great" + randomWord + ", and makes my life very happy.\" But whenever there is"
+ " my " + noun3 + " begins to" + adj1 + " fast. The " + noun4 + " then turned around and " + adj2 + " the perpatrator, then he " + verb1 + " his body to a" + lastWord +"";

Console.WriteLine(story);
    
     string ending = Console.ReadLine();
     if(ending == "end")
    {
        TryAgain = false;
        end = true;
    } 

    


}