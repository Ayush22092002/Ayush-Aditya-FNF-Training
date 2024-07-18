const emp={
    empName:"Ayush",
    empAddress:"Bangalore",
    empSalary:9000
}
console.log(emp)

let emp2=emp;
emp2.empSalary=1000

console.log(emp.empSalary)
console.log(emp2.empSalary)

for(const key in emp)
{
    console.log(`Property:${key},Value:${emp[key]}`);
}
const emp3={...emp,empDesignation:"Trainer"}
console.log(emp3)


let employee=function(id,name,address)
{
    this.id=id
     this.name=name
    this.address=address

    this.display=function()
    {
        return`${this.empName} is from ${this.empAddress}`
    }
}

let employee1=new employee(123,"abc","pune")
let employee2=new employee(124,"def","chennai")
alert(employee2.display())
employee2.empAddress="Don"
console.log(employee1.empAddress);
console.log(employee2.empAddress);


class Customer
{
    constructor(id,name,address,bill)
    {
        this.id=id
        this.name=name
        this.address=address
        this.billAmount=bill
    }
    display=()=>`${this.name} is from ${this.address}and has bill of Rs ${this.bill}`
}
    let cst=new Customer(123,"kk","patna",15000)
    alert(cst.display())

