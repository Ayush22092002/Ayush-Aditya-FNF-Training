const fruits=["Apples","Banana","Mango"]

/*console.log(fruits)

for(let index=0;index<fruits.length;index++)
{
    console.log(fruits[index])
}

for(const element of fruits)
{
    console.log(fruits[element])
}

for(const key in fruits)
{
    console.log(`Index:${key}: Value:${fruits[key]}`)
}   */
        
fruits.push("Pine Apples")
fruits.push("Ooty Apples")
fruits.push("American Apples")

fruits.unshift("Kiwi Apple")
fruits.splice(2,1,"Gauva")

for(const element of fruits)
    {
        console.log(element)
    }

