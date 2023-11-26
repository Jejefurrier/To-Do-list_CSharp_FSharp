namespace Todo

module Services =
    
    open Common
    let List : Todo[] =
        DataAccess.List        

    let Create (todo:Todo) : bool = 
        if todo.IsValid() then
            DataAccess.Insert(todo)
            true
        else
            false

    let Read =
        Todo.DataAccess.List

    let Update (todo:Todo) : bool = 
        if not (todo.IsValid()) then
            false
        else
            let result = Todo.DataAccess.Edit(todo)
            result

    let Delete (id: int) : bool =
        Todo.DataAccess.Delete(id)
        true

        
            
