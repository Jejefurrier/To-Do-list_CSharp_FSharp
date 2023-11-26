namespace Todo

module DataAccess =

    open Common    
    let Insert (todo: Todo) = 
        FakeDataBase.TodoList.Add(todo)
    
    let List : Todo[] =
        FakeDataBase.TodoList.ToArray()

    open System.Linq
    let Edit (newTodo: Todo) : bool =
        let index = FakeDataBase.TodoList.FindIndex(fun t -> t.ID = newTodo.ID)
        FakeDataBase.TodoList[index] <- newTodo
        true

    let Delete (id: int) =
        let index = FakeDataBase.TodoList.FindIndex(fun x -> x.ID = id)
        FakeDataBase.TodoList.RemoveAt(index)
        