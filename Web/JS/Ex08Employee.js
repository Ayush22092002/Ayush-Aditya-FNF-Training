class Employee{
    constructor(id, name, address, salary){
        this.empId=id;
        this.empName=name;
        this.empAddress=address;
        this.empSalary=salary;
    }
}
class EmployeeRepo{
    data=[];
    constructor(){
        this.loadData();
    }
    loadData=()=>{
        if(localStorage.getItem("empList")!=null){
            const json=localStorage.getItem("empList");
            this.data=JSON.parse(json);
        }
    }
    saveData=()=>{
        const json=JSON.stringify(this.data)
        localStorage.setItem("empList",json)
    }
 
    addNewEmployee=(emp)=>{   //this.data.push(emp);
        this.loadData();
        this.data=[...this.data,emp];
        this.saveData();
       
    }
       
    deleteEmployee=(id)=>{
        let index=this.data.findIndex((e)=>e.empId==id);
        this.data.splice(index,1)//removing an element in Js's array.
        this.saveData();
    }
 
    getAllEmployees=()=>{   //this.data;//=>[...this.data]
        this.loadData();
        return this.data;
    }    
 
    updateEmployee=(id,emp)=>{
        let index=this.data.findIndex((e)=>e.empId==id);
        this.data.splice(index,1,emp)
        this.saveData();//remove the no of elments (2nd arg)from the specific index(1st arg) and replace it with the emp object(3rd arg)
    }
}
 
//const hide=(...element)=>[...element].forEach(e=>(e.style.display='none'));
 
//hideElements(...document.querySelectorAll('section'))
 
//const show=(id)=> document.getElementById(id).style.display='block';
const hide = function(elements){
    elements.forEach(element => {
        element.style.display = "none"
    });
}
const show = (id) => document.getElementById(id).style.display = 'block';