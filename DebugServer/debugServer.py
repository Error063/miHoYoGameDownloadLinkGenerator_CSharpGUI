from flask import Flask, request
import json

app = Flask(__name__)

# 该程序用于模拟米哈游服务器所返回的游戏客户端资源下载链接集合，以测试程序是否运行正常

resourceJson = """{
  "data": {
    "game": {
      "latest": {
        "name": "",
        "version": "2.2.0",
        "path": "https://autopatchcn.yuanshen.com/client_app/pc_mihoyo/20211013_a336065295309dbe/YuanShen_2.2.0.zip",
        "size": "47244640256",
        "md5": "27AA98C93AFF1359CCAF6834B5F4767F",
        "entry": "YuanShen.exe",
        "voice_packs": [
          {
            "language": "zh-cn",
            "name": "Audio_Chinese_2.2.0.zip",
            "path": "https://autopatchcn.yuanshen.com/client_app/pc_mihoyo/20211013_a336065295309dbe/Audio_Chinese_2.2.0.zip",
            "size": "9663676416",
            "md5": "F54C26A356391E2E72EB8BDC585AFDF6"
          },
          {
            "language": "en-us",
            "name": "Audio_English(US)_2.2.0.zip",
            "path": "https://autopatchcn.yuanshen.com/client_app/pc_mihoyo/20211013_a336065295309dbe/Audio_English(US)_2.2.0.zip",
            "size": "10737418240",
            "md5": "D67AB0DE8A4BD7521037A587AFFB8F55"
          },
          {
            "language": "ja-jp",
            "name": "Audio_Japanese_2.2.0.zip",
            "path": "https://autopatchcn.yuanshen.com/client_app/pc_mihoyo/20211013_a336065295309dbe/Audio_Japanese_2.2.0.zip",
            "size": "11811160064",
            "md5": "FA8EA2E0F591AA2046DF906A24AB6E95"
          },
          {
            "language": "ko-kr",
            "name": "Audio_Korean_2.2.0.zip",
            "path": "https://autopatchcn.yuanshen.com/client_app/pc_mihoyo/20211013_a336065295309dbe/Audio_Korean_2.2.0.zip",
            "size": "9663676416",
            "md5": "2265A29DC5D88624AA6C604873D9C57D"
          }
        ],
        "decompressed_path": "https://autopatchcn.yuanshen.com/client_app/pc_mihoyo/20211013_a336065295309dbe/2.2.0",
        "segments": []
      },
      "diffs": [
        {
          "name": "game_2.1.0_2.2.0_diff_gCYOaDcXKismNxb8.zip",
          "version": "2.1.0",
          "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/game_2.1.0_2.2.0_diff_gCYOaDcXKismNxb8.zip",
          "size": "11485514280",
          "md5": "1BC1702E0FD51551D5C989DDB5E9A5B5",
          "is_recommended_update": false,
          "voice_packs": [
            {
              "language": "zh-cn",
              "name": "zh-cn_2.1.0_2.2.0_diff_Puh1miF0jOLkweHD.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/zh-cn_2.1.0_2.2.0_diff_Puh1miF0jOLkweHD.zip",
              "size": "583279860",
              "md5": "3277D3A71ACE61A9794B563B5BEF91C8"
            },
            {
              "language": "en-us",
              "name": "en-us_2.1.0_2.2.0_diff_o25QjGWDUJlgbrMc.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/en-us_2.1.0_2.2.0_diff_o25QjGWDUJlgbrMc.zip",
              "size": "715639728",
              "md5": "509AEB19C0581E80004C3B40CF9EB193"
            },
            {
              "language": "ja-jp",
              "name": "ja-jp_2.1.0_2.2.0_diff_LYt3QsNSB24o8uJR.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/ja-jp_2.1.0_2.2.0_diff_LYt3QsNSB24o8uJR.zip",
              "size": "777321236",
              "md5": "73DCD15A96978E4A2EA4EDB77308CE58"
            },
            {
              "language": "ko-kr",
              "name": "ko-kr_2.1.0_2.2.0_diff_utK5Hb0cqh6o7eTJ.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/ko-kr_2.1.0_2.2.0_diff_utK5Hb0cqh6o7eTJ.zip",
              "size": "572665538",
              "md5": "D72DE6A0B16AFADCC7D28067F7592A3C"
            }
          ]
        },
        {
          "name": "game_2.0.0_2.2.0_diff_oWEf7mTHnSPLBr84.zip",
          "version": "2.0.0",
          "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/game_2.0.0_2.2.0_diff_oWEf7mTHnSPLBr84.zip",
          "size": "20764351428",
          "md5": "A8CDC10DDDC94383D43C782418A50CEB",
          "is_recommended_update": false,
          "voice_packs": [
            {
              "language": "zh-cn",
              "name": "zh-cn_2.0.0_2.2.0_diff_T3YBPKfdh2i1qmxn.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/zh-cn_2.0.0_2.2.0_diff_T3YBPKfdh2i1qmxn.zip",
              "size": "1803297543",
              "md5": "3C3FCA0B64AEAD58DBFF9543D06317D0"
            },
            {
              "language": "en-us",
              "name": "en-us_2.0.0_2.2.0_diff_0diwUhN3HLB9A2ju.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/en-us_2.0.0_2.2.0_diff_0diwUhN3HLB9A2ju.zip",
              "size": "2818337725",
              "md5": "A4D544558934826B0C70ABE1EA9092E8"
            },
            {
              "language": "ja-jp",
              "name": "ja-jp_2.0.0_2.2.0_diff_25NZrflSVBeJuFOK.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/ja-jp_2.0.0_2.2.0_diff_25NZrflSVBeJuFOK.zip",
              "size": "2071191629",
              "md5": "DAACB65ED560FF15A27CDC3C039601BE"
            },
            {
              "language": "ko-kr",
              "name": "ko-kr_2.0.0_2.2.0_diff_IuZ1oLHpJv2B6aWf.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/ko-kr_2.0.0_2.2.0_diff_IuZ1oLHpJv2B6aWf.zip",
              "size": "2209443433",
              "md5": "463D02C3D2F942A096ED8270B665B8C4"
            }
          ]
        }
      ]
    },
    "plugin": {
      "plugins": [
        {
          "name": "DXSETUP.zip",
          "version": "",
          "path": "https://autopatchcn.yuanshen.com/client_app/plugins/DXSETUP.zip",
          "size": "100647892",
          "md5": "CA2AC3835D7D7DA6CB8624FEFB177083",
          "entry": ""
        }
      ],
      "version": "1"
    },
    "web_url": "https://ys.mihoyo.com/launcher",
    "force_update": null,
    "pre_download_game": {
      "latest": {
        "name": "",
        "version": "2.3.0",
        "path": "https://autopatchcn.yuanshen.com/client_app/download/pc_zip/20211117173857_8JkfDHNPmqKi67qR/YuanShen_2.3.0.zip",
        "size": "50465865728",
        "md5": "4465ea48befb40cfed01b125e65c03f0",
        "entry": "YuanShen.exe",
        "voice_packs": [
          {
            "language": "zh-cn",
            "name": "Audio_Chinese_2.3.0.zip",
            "path": "https://autopatchcn.yuanshen.com/client_app/download/pc_zip/20211117173857_8JkfDHNPmqKi67qR/Audio_Chinese_2.3.0.zip",
            "size": "10737418240",
            "md5": "c9c3a680c4a9b7b3f1d455c14e6087da"
          },
          {
            "language": "en-us",
            "name": "Audio_English(US)_2.3.0.zip",
            "path": "https://autopatchcn.yuanshen.com/client_app/download/pc_zip/20211117173857_8JkfDHNPmqKi67qR/Audio_English(US)_2.3.0.zip",
            "size": "11811160064",
            "md5": "f8e6a1ab3596eb7ca7216ff0585d609f"
          },
          {
            "language": "ja-jp",
            "name": "Audio_Japanese_2.3.0.zip",
            "path": "https://autopatchcn.yuanshen.com/client_app/download/pc_zip/20211117173857_8JkfDHNPmqKi67qR/Audio_Japanese_2.3.0.zip",
            "size": "12884901888",
            "md5": "ae0c2a7aa7ad7073db9627ddbd994d23"
          },
          {
            "language": "ko-kr",
            "name": "Audio_Korean_2.3.0.zip",
            "path": "https://autopatchcn.yuanshen.com/client_app/download/pc_zip/20211117173857_8JkfDHNPmqKi67qR/Audio_Korean_2.3.0.zip",
            "size": "10737418240",
            "md5": "d1e8c5aa3d2e53c7bee01d3bdf40173d"
          }
        ],
        "decompressed_path": "https://autopatchcn.yuanshen.com/client_app/download/pc_zip/20211117173857_8JkfDHNPmqKi67qR/ScatteredFiles",
        "segments": []
      },
      "diffs": [
        {
          "name": "game_2.2.0_2.3.0_diff_EtexVWZo01qNRsAD.zip",
          "version": "2.2.0",
          "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/game_2.2.0_2.3.0_diff_EtexVWZo01qNRsAD.zip",
          "size": "10085194217",
          "md5": "86C7EF055768BB27536DD61CD9DFDA10",
          "is_recommended_update": false,
          "voice_packs": [
            {
              "language": "zh-cn",
              "name": "zh-cn_2.2.0_2.3.0_diff_4oTGH3OZD8QkdKsC.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/zh-cn_2.2.0_2.3.0_diff_4oTGH3OZD8QkdKsC.zip",
              "size": "821707187",
              "md5": "5B12F484F049B2CEA936A38CFD0DA041"
            },
            {
              "language": "en-us",
              "name": "en-us_2.2.0_2.3.0_diff_oBE0Ydl5p4swubz8.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/en-us_2.2.0_2.3.0_diff_oBE0Ydl5p4swubz8.zip",
              "size": "1032022231",
              "md5": "FE65DB12ADCF53AE18394061A499A000"
            },
            {
              "language": "ja-jp",
              "name": "ja-jp_2.2.0_2.3.0_diff_CNPr6ikoe4h70pU3.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/ja-jp_2.2.0_2.3.0_diff_CNPr6ikoe4h70pU3.zip",
              "size": "1112833961",
              "md5": "CFC0FB9E7188F0CAAB5F3E434F7674A6"
            },
            {
              "language": "ko-kr",
              "name": "ko-kr_2.2.0_2.3.0_diff_7u0hWSmzDLbCTUqP.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/ko-kr_2.2.0_2.3.0_diff_7u0hWSmzDLbCTUqP.zip",
              "size": "853600270",
              "md5": "9277D3B5CEC29221A7FBE54FE1B007A7"
            }
          ]
        },
        {
          "name": "game_2.1.0_2.3.0_diff_7h1m5EZuVU6otB9I.zip",
          "version": "2.1.0",
          "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/game_2.1.0_2.3.0_diff_7h1m5EZuVU6otB9I.zip",
          "size": "14742723111",
          "md5": "E0D5796993917046788879A01D8B626D",
          "is_recommended_update": false,
          "voice_packs": [
            {
              "language": "zh-cn",
              "name": "zh-cn_2.1.0_2.3.0_diff_zAuneqLE1cZ7mO0w.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/zh-cn_2.1.0_2.3.0_diff_zAuneqLE1cZ7mO0w.zip",
              "size": "1394474566",
              "md5": "0D4E825B05BDEE54E21D09DC67D45993"
            },
            {
              "language": "en-us",
              "name": "en-us_2.1.0_2.3.0_diff_VIZGBofTkNaO2RMK.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/en-us_2.1.0_2.3.0_diff_VIZGBofTkNaO2RMK.zip",
              "size": "1737147296",
              "md5": "27B53FA253BC1E3D1F96F6280D0519CE"
            },
            {
              "language": "ja-jp",
              "name": "ja-jp_2.1.0_2.3.0_diff_3smBOE1uPYNj5KXD.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/ja-jp_2.1.0_2.3.0_diff_3smBOE1uPYNj5KXD.zip",
              "size": "1879638758",
              "md5": "0CC12A4AB51E4C421FB0E3B18A24F9B5"
            },
            {
              "language": "ko-kr",
              "name": "ko-kr_2.1.0_2.3.0_diff_X46Wk3KI9jbosURh.zip",
              "path": "https://autopatchcn.yuanshen.com/client_app/update/hk4e_cn/18/ko-kr_2.1.0_2.3.0_diff_X46Wk3KI9jbosURh.zip",
              "size": "1415754656",
              "md5": "4EFAD4B70C41AA30484B7E08B6585A05"
            }
          ]
        }
      ]
    },
    "deprecated_packages": [
      {
        "name": "game_1.6.0_2.1.0_diff_tkLn4PAmDSZ7W9Ns.zip",
        "md5": "328058E8A1ECEBD48E9D261AB27D7C4B"
      },
      {
        "name": "zh-cn_1.6.0_2.1.0_diff_cLUSTVHgI5i3Jh8n.zip",
        "md5": "1F5F116F57F2D41E6583D11609554135"
      },
      {
        "name": "en-us_1.6.0_2.1.0_diff_6yqerl7ijs8vYBNC.zip",
        "md5": "23EE4EB03DC7C1A217CB1E69B58E3EB1"
      },
      {
        "name": "ja-jp_1.6.0_2.1.0_diff_mkDIo7tTQKYCMycS.zip",
        "md5": "2ABB1E2410455C28BF0E4071C650851E"
      },
      {
        "name": "ko-kr_1.6.0_2.1.0_diff_sT19MrKIabduXkqh.zip",
        "md5": "F77DF7158C9F8A327F6C1874F900DC7C"
      },
      {
        "name": "game_2.0.0_2.1.0_diff_1f7AFLVjigMhXBnd.zip",
        "md5": "7A5D63BD4430DC0999E6E8B39A7BDEF7"
      },
      {
        "name": "zh-cn_2.0.0_2.1.0_diff_SOLUbvTEIh4BesHX.zip",
        "md5": "1EC1118D1F0B423231946BCE1B988622"
      },
      {
        "name": "en-us_2.0.0_2.1.0_diff_0NQJkKFycz3sEfvL.zip",
        "md5": "6F0D829A38E4F8EF534425DD56365A1A"
      },
      {
        "name": "ja-jp_2.0.0_2.1.0_diff_KTHWOyf2gJEDRBIa.zip",
        "md5": "DBBE9B5F37DC6996A214D10E1C79018B"
      },
      {
        "name": "ko-kr_2.0.0_2.1.0_diff_YNRh8WTKAkI5UlCB.zip",
        "md5": "1522A3258D69AAF848C324D8A7779C58"
      },
      {
        "name": "YuanShen_2.1.0.zip",
        "md5": "8B3DA842AFC60BF18C906B7A9D0ED520"
      },
      {
        "name": "Audio_Chinese_2.1.0.zip",
        "md5": "9F669C3B4FB4F99901AC494046179C4B"
      },
      {
        "name": "Audio_English(US)_2.1.0.zip",
        "md5": "ABF3835749E703E291A865AF7EF6A5B3"
      },
      {
        "name": "Audio_Japanese_2.1.0.zip",
        "md5": "50BDA2C40F1F30DBA7672B6C86C7AE2C"
      },
      {
        "name": "Audio_Korean_2.1.0.zip",
        "md5": "714A8809602BC6025C284D39B229607F"
      },
      {
        "name": "game_1.5.1_2.0.0_diff_KPflNBewubhsp2oV.zip",
        "md5": "59F5394A600445145ACC1EFB79DF809C"
      },
      {
        "name": "zh-cn_1.5.1_2.0.0_diff_fYXCx4RSwrubmKVo.zip",
        "md5": "A4765D7D4DF2A01711D5822FAC9F674D"
      },
      {
        "name": "en-us_1.5.1_2.0.0_diff_PojINd5kDvUiO012.zip",
        "md5": "5F6D6D78C8EF83F0DB54380603580F8D"
      },
      {
        "name": "ja-jp_1.5.1_2.0.0_diff_izZxrbCVAM2P0F1G.zip",
        "md5": "B75B8BA15712A2B489CF2F8F5512125A"
      },
      {
        "name": "ko-kr_1.5.1_2.0.0_diff_U4qRYTBiVDf6OJEy.zip",
        "md5": "D0BD1A1996DA17F16062BF78D1EC5A9F"
      },
      {
        "name": "game_1.6.0_2.0.0_diff_TYDKcOolbt83EzFd.zip",
        "md5": "FDA794782085872EC28367A589FC600D"
      },
      {
        "name": "zh-cn_1.6.0_2.0.0_diff_0mYpgH2U5TPRjoka.zip",
        "md5": "4FCFEF74458020879DBF1DC32DFBBD17"
      },
      {
        "name": "en-us_1.6.0_2.0.0_diff_KHxh8fB6mLz0PjE7.zip",
        "md5": "6A7197E781C11C09FB53B692C15B0E4A"
      },
      {
        "name": "ja-jp_1.6.0_2.0.0_diff_uyn3OiEvBPYm96MA.zip",
        "md5": "E2911F6E4BB60F0BD66E81C30B9D1932"
      },
      {
        "name": "ko-kr_1.6.0_2.0.0_diff_BbgEkio01XD84xKY.zip",
        "md5": "839170163BD645BFA89703D42ADA4293"
      },
      {
        "name": "YuanShen_2.0.0.zip",
        "md5": "7B454A68FA48EC8549E51FC12416A886"
      },
      {
        "name": "Audio_Chinese_2.0.0.zip",
        "md5": "D53BBE7E92FEF94E907B7D2130AAAC08"
      },
      {
        "name": "Audio_English(US)_2.0.0.zip",
        "md5": "CE0AF27A5CDE69A5509371083B284305"
      },
      {
        "name": "Audio_Japanese_2.0.0.zip",
        "md5": "C17DC6A6C9D97291E1C6CE3C2A5A40B1"
      },
      {
        "name": "Audio_Korean_2.0.0.zip",
        "md5": "0670F06CB123F28877087D7724730335"
      }
    ],
    "sdk": null
  },
  "message": "OK",
  "retcode": 0
}"""

@app.route('/api')
def hello_world():
    raw = json.loads(resourceJson)
    if request.args["from"] == "debug":
        return json.dumps(raw)


if __name__ == '__main__':
    app.run()
