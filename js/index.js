import Singleton from "./pattern"

const example = Singleton.getInstance()

example.addUrl("http://google.com")
example.addUrl("http://google.com")
example.addUrl("https://github.com/")
example.addUrl("https://github.com/")
example.print()
example.clearHistory()
example.print()