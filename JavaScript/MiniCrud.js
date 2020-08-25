class Service{

    constructor (info){
        this.info = new Array (info)
    }

    add(object){
        this.info.push(object)
    }

    getByID(id){
        return this.info[id]
    }

    getAll(){
        return this.info
    }

    deleteByID(id){
        let removed = this.info[id]
        this.info.splice(id, 1)
        return removed
    }

    updateByID(id, object){
        this.info.splice(id, object.length, object)
    }

    replaceByID(id, object){
        this.info.delete(id)
        this.info[id] = object
    }
}