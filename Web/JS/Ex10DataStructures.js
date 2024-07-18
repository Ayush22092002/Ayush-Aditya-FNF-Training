function setExample()
 {
    let set = new Set()
    set.add("item1")
    if (set.has("item1")) 
    {
        console.log("Item already exist")
    } 
    else 
    {
        set.add("item1");
    }
    return set;
}