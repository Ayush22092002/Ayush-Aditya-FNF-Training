let v1=parseFloat(prompt("Enter The First Value"))
if(isNaN(v1))
{
    alert("This is not a valid number ,so taking 0")
    v1=0
}

let v2=parseFloat(prompt("Enter The Second Value"))
if(isNaN(v2))
{
        alert("This is not a valid number ,so taking 0")
        v2=0
}


let op=prompt("Enter The Choice as +,-,* or /")    

switch(op)
{
    case '+' : alert(v1+v2);break;
    case '-' : alert(v1-v2);break;
    case '*' : alert(v1*v2);break;
    case '/' : alert(v1/v2);break;

    default:alert("Wrong Input")

}
