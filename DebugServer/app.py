from flask import Flask, request
import json

app = Flask(__name__)

# 该程序用于模拟米哈游服务器所返回的游戏客户端资源下载链接集合，以测试程序是否运行正常
# 示例Json文件获取自 https://archive.org/web/
# Json文件所记录的是 原神 2.2.0 天空岛服务器的游戏资源（包含2.3.0的预更新）

@app.route('/api')
def hello_world():
    with open("data.json") as f:
        raw = json.load(f)
    if request.args["from"] == "debug":
        return json.dumps(raw)


if __name__ == '__main__':
    app.run()
