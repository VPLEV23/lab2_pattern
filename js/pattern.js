let singleton = Symbol()
let singletonEnforcer = Symbol()

class Singleton {
    UrlList = {}
    constructor(enforcer) {
        if (enforcer !== singletonEnforcer)
            throw "Instantiation failed: use Singleton.getInstance() instead of new."
    }

    static get _instance() {
        if (!this[singleton])
            this[singleton] = new Singleton(singletonEnforcer)
        return this[singleton]
    }

    static set _instance(v) { throw "не можлтво змінити констатнту!" }
    static getInstance() { return this._instance }

    addUrl = url => this.UrlList.hasOwnProperty(url) ? this.UrlList[url] += 1 : this.UrlList[url] = 1

    clearHistory() {
        this.UrlList = {}
        console.log("Історія була очищена!")
    }

    print() {
        if (Object.keys(this.UrlList).length) {
            for (let item in this.UrlList)
                console.log(`Url: ${item}, кількість кліків: ${this.UrlList[item]}`)
        }
        else console.log("Url історія пуста!")
    }

}

export default Singleton