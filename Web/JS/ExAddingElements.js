const items =[];//blank array
const Additem = (item)=>items.push(item);
 
const removeitem =(item)=>{
    let index = items.indexOf(item);
    if(index<0){
        throw "item not found to remove";
    }
    items.splice(index,1);
}
 
const getAllitems=()=>items;