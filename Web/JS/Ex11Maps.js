function mapExample()
{
        const items=new Map()

        items.set("Apples",200)
        items.set("Mangoes",120)
        items.set("Kiwi",180)
        items.set("Dragon Fruit",100)
        items.set("Grapes",60)

        console.log(items.has("Mangoes"))
        for(const pair of items)
        {
            console.log(`Key:${pair}`)
        }
}