#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Home\Flood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752112706a30c3cd04d48a781e8d9c4be35f9a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Flood), @"mvc.1.0.view", @"/Views/Home/Flood.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Flood.cshtml", typeof(AspNetCore.Views_Home_Flood))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\_ViewImports.cshtml"
using NaturalDisasterDatabaseWebsite;

#line default
#line hidden
#line 2 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\_ViewImports.cshtml"
using NaturalDisasterDatabaseWebsite.Models;

#line default
#line hidden
#line 5 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\_ViewImports.cshtml"
using NaturalDisasterDatabaseWebsite.Controllers;

#line default
#line hidden
#line 1 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Home\Flood.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"752112706a30c3cd04d48a781e8d9c4be35f9a76", @"/Views/Home/Flood.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Flood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 1130, true);
            WriteLiteral(@"
<div style=""width: 100%; height: 402px; background:-webkit-gradient(linear, 0 0, 0 100%, from(rgba(0,0,255,0.5)), to(rgba(0,0,255,0.8)));"">
    <div id=""floodArea"" style=""width: 100%; height: 378px;"" class=""floodfour0""></div>
    <div id=""floodecoloss"" style=""width: 100%; height: 378px; display:none;"" class=""floodfour1""></div>
    <p class=""floodbtn"" style=""margin:0 auto; text-align:center; color:#fff; height:24px; line-height:18px;"">
        <button id=""floodsczarea"">受/成灾面积</button>&emsp;<button id=""floodloss"">经济损失</button>
    </p>
</div>
<script type=""text/javascript"">
    $(function () {
        $("".floodbtn button"").click(function () {
            var orderflood = $("".floodbtn button"").index(this);//获取点击之后返回当前a标签index的值
            $("".floodfour"" + orderflood).show().siblings(""div"").hide();//显示class中con加上返回值所对应的DIV
            var orderfloodbtn = ""floodfour"" + orderflood;
            if (orderfloodbtn == ""floodfour1"") {
                FloodEconomicLoss();
            } else if (orderflo");
            WriteLiteral("odbtn == \"floodfour0\") {\r\n                FloodAllArea();\r\n            }\r\n        });\r\n    })\r\n</script>\r\n");
            EndContext();
#line 24 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Home\Flood.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(1216, 14661, true);
            WriteLiteral(@"    <script type=""text/javascript"">
        FloodAllArea();
        function FloodAllArea() {
            var myFloodAreaCharts = echarts.init(document.getElementById('floodArea'));
            myFloodAreaCharts.clear();//用于清除已存在的内容
            myFloodAreaCharts.showLoading();
            $(document).ready(function () {
                $.ajax({
                    type: ""get"",
                    url: ""/Home/GetFloodCharts"",
                    dataType: 'json',
                    data: {},
                    cache: false,
                    success: function (res) {
                        //console.log(res);
                        var floodyears = [], floodagrisz = [], floodagricz = [], floodwasz = [], floodwacz = [], flooddrsz = [], flooddrcz = [], floodcl = [];
                        for (var i = 0; i < res.floodlist.length; i++) {
                            floodyears[i] = res.floodlist[i].fYears;
                            floodagrisz[i] = res.floodlist[i].fAgrishouzArea;
     ");
            WriteLiteral(@"                       floodagricz[i] = res.floodlist[i].fAgrichengzArea;
                            floodwasz[i] = res.floodlist[i].fWatershouzArea;
                            floodwacz[i] = res.floodlist[i].fWaterchengzArea;
                            flooddrsz[i] = res.floodlist[i].fDroughtshouzArea;
                            flooddrcz[i] = res.floodlist[i].fDroughtchengzArea;
                            floodcl[i] = res.floodlist[i].fDrainageArea;
                        }

                        myFloodAreaCharts.hideLoading();
                        var xAxisData = [];
                        var data1 = [], data2 = [], data3 = [], data4 = [], data5 = [], data6 = [], data7 = [];
                        for (var i = 0; i < floodyears.length; i++) {
                            xAxisData.push(floodyears[i]);
                            data1.push(floodagrisz[i]);
                            data2.push(floodagricz[i]);
                            data3.push(floodwasz[i]);
            ");
            WriteLiteral(@"                data4.push(floodwacz[i]);
                            data5.push(flooddrsz[i]);
                            data6.push(flooddrcz[i]);
                            data7.push(floodcl[i]);
                        }

                        option = {
                            //backgroundColor: {
                            //    type: 'linear',
                            //    x: 0,                 // 左上角x
                            //    y: 0,                 // 左上角y
                            //    x2: 0,                // 右下角x
                            //    y2: 1,                // 右下角y
                            //    colorStops: [{
                            //        offset: 0, color: 'rgba(0,0,255,0.8)' // 0% 处的颜色
                            //    }, {
                            //        offset: 1, color: 'rgba(0,0,255,0.7)' // 100% 处的颜色
                            //    }],
                            //    global: false // 缺省为 false
                       ");
            WriteLiteral(@"     //},
                            legend: {
                                data: ['农业受灾面积', '农业成灾面积', '水灾受灾面积', '水灾成灾面积', '旱灾受灾面积', '旱灾成灾面积', '除涝面积'],
                                top: '8%',
                                textStyle: {
                                    color: '#fff'
                                }
                            },
                            brush: {
                                showTitle: false,
                                toolbox: ['rect', 'polygon', 'lineX', 'lineY', 'keep', 'clear'],
                                xAxisIndex: 0,
                            },
                            toolbox: {
                                // y: 'bottom',
                                iconStyle: {
                                    borderColor: '#fff'
                                },
                                emphasis: {
                                    iconStyle: {
                                        borderColor: '#f00'
      ");
            WriteLiteral(@"                              },
                                },
                                showTitle: false,
                                feature: {
                                    dataView: { //数据视图
                                        show: true,
                                        readOnly: false,
                                        lang: ['', '关闭', '导出Excel'],
                                        buttonColor: '#30C76C',
                                        iconStyle: {
                                            borderColor: '#fff'
                                        },
                                        emphasis: {
                                            iconStyle: {
                                                borderColor: '#f00'
                                            },
                                        },
                                        contentToOption: function (opts) {
                                            //");
            WriteLiteral(@"console.log(opts)
                                            $.noConflict(); //请务必加上这一句，否则无法下载excel
                                            $(""#tableExcel_Flood"").table2excel({ //通过id即tableExcel_Day
                                                exclude: "".noExl"", //过滤位置的 css 类名：有class=""noExl""的行不被导出
                                                name: ""表格-"" + new Date().getTime(),
                                                filename: ""广西洪水灾害受/成灾面积"" + new Date().getTime() + "".xls"", //文件名称
                                                exclude_img: true,
                                                exclude_links: true,
                                                exclude_inputs: true
                                            });
                                        },
                                        optionToContent: function (opt) {
                                            var axisData = opt.xAxis[0].data; // 坐标数据
                                            var ser");
            WriteLiteral(@"ies = opt.series; // 折线图数据
                                            var tdHeaders = '<td></td><td>年份</td>'; // 表头第一列
                                            for (var k = 0; k < series.length; k++) {
                                                tdHeaders += '<td style=""padding:0px 2px;"">' + series[k].name + '(千公顷)</td>'; //组装表头

                                            }
                                            var table = '<div style=""overflow-y:auto;height: 100%;width:100%;""><table id=""tableExcel_Flood"" class=""table-bordered table-striped"" style=""text-align:center; border-collapse:collapse; margin:0 auto; text-align:center;"" border=""1"" ><tbody><tr>' + tdHeaders + '</tr>';
                                            var tdBodys = ''; // 表数据
                                            for (var i = 0, l = axisData.length; i < l; i++) {
                                                for (var j = 0; j < series.length; j++) {
                                                    var temp =");
            WriteLiteral(@" series[j].data[i];
                                                    if (temp != null && temp != undefined) {
                                                        tdBodys += '<td>' + series[j].data[i] + '</td>'; //组装表数据
                                                    } else {
                                                        tdBodys += '<td></td>';
                                                    }
                                                }
                                                table += '<tr><td style=""padding:0 6px;"">' + (i + 1) + '</td><td style=""padding: 0 10px"">' + axisData[i] + '</td>' + tdBodys + '</tr>';
                                                tdBodys = '';
                                            }
                                            table += '</tbody></table></div>';
                                            return table;
                                        },
                                    },
                            ");
            WriteLiteral(@"        magicType: {
                                        type: ['stack', 'tiled'],
                                        iconStyle: {
                                            borderColor: '#fff'
                                        },
                                        emphasis: {
                                            iconStyle: {
                                                borderColor: '#f00'
                                            },
                                        }
                                    },
                                    restore: {
                                        iconStyle: {
                                            borderColor: '#fff'
                                        },
                                        emphasis: {
                                            iconStyle: {
                                                borderColor: '#f00'
                                            },
                      ");
            WriteLiteral(@"                  }
                                    },
                                    saveAsImage: {
                                        pixelRatio: 2,
                                        iconStyle: {
                                            borderColor: '#fff'
                                        },
                                        emphasis: {
                                            iconStyle: {
                                                borderColor: '#f00'
                                            },
                                        }
                                    }
                                },
                                tooltip: {
                                    show: true,
                                    textStyle: {
                                        color: '#fff'
                                    }
                                }
                            },
                            grid: {
     ");
            WriteLiteral(@"                           left: '4.5%',
                                right: '3.5%',
                                bottom: '3%',
                                containLabel: true
                            },
                            tooltip: {
                                formatter: function (e) {
                                    //console.log(e)
                                    return e.seriesName + '<br />' + e.name + ""年："" + e.value + "" 千公顷<br />""
                                }
                            },
                            xAxis: {
                                data: xAxisData,
                                name: '年',
                                color: '#fff',
                                axisLine: {
                                    lineStyle: {
                                        color: '#fff'
                                    }
                                },
                                axisLabel: {
                       ");
            WriteLiteral(@"             color: '#fff', //x轴字体颜色
                                    interval: 0,
                                },
                            },
                            yAxis: {
                                type: 'value',
                                name: '受/成灾面积（单位：千公顷）',
                                splitLine: { show: false },
                                axisLine: {
                                    lineStyle: {
                                        color: '#fff'
                                    }
                                }
                            },
                            series: [{
                                name: '农业受灾面积',
                                type: 'bar',
                                data: data1,
                                animationDelay: function (idx) {
                                    return idx * 10;
                                }
                            }, {
                                name: ");
            WriteLiteral(@"'农业成灾面积',
                                type: 'bar',
                                data: data2,
                                animationDelay: function (idx) {
                                    return idx * 10 + 100;
                                }
                            },
                            {
                                name: '水灾受灾面积',
                                type: 'bar',
                                data: data3,
                                animationDelay: function (idx) {
                                    return idx * 10;
                                }
                            }, {
                                name: '水灾成灾面积',
                                type: 'bar',
                                data: data4,
                                animationDelay: function (idx) {
                                    return idx * 10 + 100;
                                }
                            }, {
                               ");
            WriteLiteral(@" name: '旱灾受灾面积',
                                type: 'bar',
                                data: data5,
                                animationDelay: function (idx) {
                                    return idx * 10;
                                }
                            }, {
                                name: '旱灾成灾面积',
                                type: 'bar',
                                data: data6,
                                animationDelay: function (idx) {
                                    return idx * 10 + 100;
                                }
                            }, {
                                name: '除涝面积',
                                type: 'bar',
                                data: data7,
                                animationDelay: function (idx) {
                                    return idx * 10;
                                }
                            }],
                            animationEasing: 'elasticOut',
  ");
            WriteLiteral(@"                          animationDelayUpdate: function (idx) {
                                return idx * 5;
                            }
                        };

                        myFloodAreaCharts.setOption(option);

                    }
                })
            })
        }
    </script>
");
            EndContext();
#line 296 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Home\Flood.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(15889, 10177, true);
            WriteLiteral(@"    <script type=""text/javascript"">
        FloodAllArea();
        function FloodAllArea() {
            var myFloodAreaCharts = echarts.init(document.getElementById('floodArea'));
            myFloodAreaCharts.clear();//用于清除已存在的内容
            myFloodAreaCharts.showLoading();
            $(document).ready(function () {
                $.ajax({
                    type: ""get"",
                    url: ""/Home/GetFloodCharts"",
                    dataType: 'json',
                    data: {},
                    cache: false,
                    success: function (res) {
                        //console.log(res);
                        var floodyears = [], floodagrisz = [], floodagricz = [], floodwasz = [], floodwacz = [], flooddrsz = [], flooddrcz = [], floodcl = [];
                        for (var i = 0; i < res.floodlist.length; i++) {
                            floodyears[i] = res.floodlist[i].fYears;
                            floodagrisz[i] = res.floodlist[i].fAgrishouzArea;
     ");
            WriteLiteral(@"                       floodagricz[i] = res.floodlist[i].fAgrichengzArea;
                            floodwasz[i] = res.floodlist[i].fWatershouzArea;
                            floodwacz[i] = res.floodlist[i].fWaterchengzArea;
                            flooddrsz[i] = res.floodlist[i].fDroughtshouzArea;
                            flooddrcz[i] = res.floodlist[i].fDroughtchengzArea;
                            floodcl[i] = res.floodlist[i].fDrainageArea;
                        }

                        myFloodAreaCharts.hideLoading();
                        var xAxisData = [];
                        var data1 = [], data2 = [], data3 = [], data4 = [], data5 = [], data6 = [], data7 = [];
                        for (var i = 0; i < floodyears.length; i++) {
                            xAxisData.push(floodyears[i]);
                            data1.push(floodagrisz[i]);
                            data2.push(floodagricz[i]);
                            data3.push(floodwasz[i]);
            ");
            WriteLiteral(@"                data4.push(floodwacz[i]);
                            data5.push(flooddrsz[i]);
                            data6.push(flooddrcz[i]);
                            data7.push(floodcl[i]);
                        }

                        option = {
                            //backgroundColor: {
                            //    type: 'linear',
                            //    x: 0,                 // 左上角x
                            //    y: 0,                 // 左上角y
                            //    x2: 0,                // 右下角x
                            //    y2: 1,                // 右下角y
                            //    colorStops: [{
                            //        offset: 0, color: 'rgba(0,0,255,0.8)' // 0% 处的颜色
                            //    }, {
                            //        offset: 1, color: 'rgba(0,0,255,0.7)' // 100% 处的颜色
                            //    }],
                            //    global: false // 缺省为 false
                       ");
            WriteLiteral(@"     //},
                            legend: {
                                data: ['农业受灾面积', '农业成灾面积', '水灾受灾面积', '水灾成灾面积', '旱灾受灾面积', '旱灾成灾面积', '除涝面积'],
                                top: '8%',
                                textStyle: {
                                    color: '#fff'
                                }
                            },
                            brush: {
                                showTitle: false,
                                toolbox: ['rect', 'polygon', 'lineX', 'lineY', 'keep', 'clear'],
                                xAxisIndex: 0,
                            },
                            toolbox: {
                                // y: 'bottom',
                                iconStyle: {
                                    borderColor: '#fff'
                                },
                                emphasis: {
                                    iconStyle: {
                                        borderColor: '#f00'
      ");
            WriteLiteral(@"                              },
                                },
                                showTitle: false,
                                feature: {
                                    magicType: {
                                        type: ['stack', 'tiled'],
                                        iconStyle: {
                                            borderColor: '#fff'
                                        },
                                        emphasis: {
                                            iconStyle: {
                                                borderColor: '#f00'
                                            },
                                        }
                                    },
                                    restore: {
                                        iconStyle: {
                                            borderColor: '#fff'
                                        },
                                        emphasis: {
    ");
            WriteLiteral(@"                                        iconStyle: {
                                                borderColor: '#f00'
                                            },
                                        }
                                    },
                                },
                                tooltip: {
                                    show: true,
                                    textStyle: {
                                        color: '#fff'
                                    }
                                }
                            },
                            grid: {
                                left: '4.5%',
                                right: '3.5%',
                                bottom: '3%',
                                containLabel: true
                            },
                            tooltip: {
                                formatter: function (e) {
                                    //console.log(e)
              ");
            WriteLiteral(@"                      return e.seriesName + '<br />' + e.name + ""年："" + e.value + "" 千公顷<br />""
                                }
                            },
                            xAxis: {
                                data: xAxisData,
                                name: '年',
                                color: '#fff',
                                axisLine: {
                                    lineStyle: {
                                        color: '#fff'
                                    }
                                },
                                axisLabel: {
                                    color: '#fff', //x轴字体颜色
                                    interval: 0,
                                },
                            },
                            yAxis: {
                                type: 'value',
                                name: '受/成灾面积（单位：千公顷）',
                                splitLine: { show: false },
                            ");
            WriteLiteral(@"    axisLine: {
                                    lineStyle: {
                                        color: '#fff'
                                    }
                                }
                            },
                            series: [{
                                name: '农业受灾面积',
                                type: 'bar',
                                data: data1,
                                animationDelay: function (idx) {
                                    return idx * 10;
                                }
                            }, {
                                name: '农业成灾面积',
                                type: 'bar',
                                data: data2,
                                animationDelay: function (idx) {
                                    return idx * 10 + 100;
                                }
                            },
                            {
                                name: '水灾受灾面积',
            ");
            WriteLiteral(@"                    type: 'bar',
                                data: data3,
                                animationDelay: function (idx) {
                                    return idx * 10;
                                }
                            }, {
                                name: '水灾成灾面积',
                                type: 'bar',
                                data: data4,
                                animationDelay: function (idx) {
                                    return idx * 10 + 100;
                                }
                            }, {
                                name: '旱灾受灾面积',
                                type: 'bar',
                                data: data5,
                                animationDelay: function (idx) {
                                    return idx * 10;
                                }
                            }, {
                                name: '旱灾成灾面积',
                                type: 'b");
            WriteLiteral(@"ar',
                                data: data6,
                                animationDelay: function (idx) {
                                    return idx * 10 + 100;
                                }
                            }, {
                                name: '除涝面积',
                                type: 'bar',
                                data: data7,
                                animationDelay: function (idx) {
                                    return idx * 10;
                                }
                            }],
                            animationEasing: 'elasticOut',
                            animationDelayUpdate: function (idx) {
                                return idx * 5;
                            }
                        };

                        myFloodAreaCharts.setOption(option);

                    }
                })
            })
        }
    </script>
");
            EndContext();
#line 507 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Home\Flood.cshtml"
}

#line default
#line hidden
            BeginContext(26069, 8827, true);
            WriteLiteral(@"
<script>
    function FloodEconomicLoss() {
        var myFloodEconoCharts = echarts.init(document.getElementById('floodecoloss'));
        myFloodEconoCharts.clear();//用于清除已存在的内容
        myFloodEconoCharts.showLoading();
        $(document).ready(function () {
            $.ajax({
                type: ""get"",
                url: ""/Home/GetFloodCharts"",
                dataType: 'json',
                data: {},
                cache: false,
                success: function (res) {
                    //console.log(res);
                    var floodlossyears = [], floodeloss = [], floodeloss2 = [], stryear = [], lossqian = [];
                    for (var u = 0; u < res.floodlist.length; u++) {
                        floodlossyears[u] = res.floodlist[u].fYears;
                        floodeloss[u] = res.floodlist[u].fEconomicLosses;
                        stryear[u] = res.floodlist[u].fYears + '年';
                    }
                    floodeloss2 = floodeloss.map(Number);
   ");
            WriteLiteral(@"                 for (var u2 = 0; u2 < floodeloss2.length; u2++) {
                        lossqian[u2] = Math.random().toFixed(2) * 100 + floodeloss2[u2];
                    }
                    //console.log(floodeloss2,lossqian)
                    myFloodEconoCharts.hideLoading();

                    option = {
                        //backgroundColor: '#7A72D6',
                        tooltip: {
                            trigger: 'axis',
                            textStyle: {
                                color: '#fff',
                            },
                            formatter: function (e) {
                                //console.log(e)
                                return e[0].marker + "" "" + e[0].name + ""："" + e[0].value + '亿元<br />'
                            }
                        },
                        grid: {
                            left: '50',
                            right: '50',
                            top: '40',
                ");
            WriteLiteral(@"            bottom: '12%',
                        },
                        xAxis: [{
                            type: 'category',
                            splitArea: {
                                show: false,
                            },
                            splitLine: {
                                show: false
                            },
                            boundaryGap: false,

                            axisLine: {
                                show: false
                            },
                            axisLabel: {
                                textStyle: {
                                    color: '#fff'
                                }
                            },
                            axisTick: {
                                show: false
                            },
                            data: stryear
                        }],
                        yAxis: [{
                            show: false,
     ");
            WriteLiteral(@"                   }],
                        series: [{
                            name: '经济损失（亿元）',
                            type: 'line',
                            symbol: 'circle',
                            //symbolSize: 15,
                            symbolSize: function (data) {
                                //console.log(data)
                                return Math.sqrt(data) * 2;
                            },
                            lineStyle: {
                                normal: {
                                    width: 2,
                                    shadowColor: 'rgba(0, 186, 0, 1)',
                                    shadowBlur: 5,
                                    shadowOffsetY: 1,
                                    shadowOffsetX: 1,
                                    type: 'dashed',
                                    color: new echarts.graphic.LinearGradient(
                                        0, 0.25, 0.75, 1,
                 ");
            WriteLiteral(@"                       [{
                                            offset: 0,
                                            color: '#ff0'
                                        },
                                        {
                                            offset: 0.25,
                                            color: '#ff0'
                                        },
                                        {
                                            offset: 0.75,
                                            color: '#ff0'
                                        },
                                        {
                                            offset: 1,
                                            color: '#ff0'
                                        },
                                        ]
                                    )
                                }
                            },
                            label: {
                                show: t");
            WriteLiteral(@"rue,
                                position: 'top',
                                nameGap: 2,
                                textStyle: {
                                    color: '#fff',
                                }
                            },
                            itemStyle: {
                                color: function (params) {
                                    let colorList = [
                                        new echarts.graphic.LinearGradient(
                                            0, 0, 1, 1, [{
                                                offset: 0,
                                                color: '#00CC00'
                                            }, {
                                                offset: 1,
                                                color: '#fff'
                                            }]),

                                    ];
                                    return colorList[params.dataIndex];
");
            WriteLiteral(@"                                },
                                borderColor: ""#fff"",
                                borderWidth: 2,
                                shadowColor: 'rgba(0, 0, 0, .3)',
                                shadowBlur: 0,
                                shadowOffsetY: 2,
                                shadowOffsetX: 2,
                            },

                            data: floodeloss2,

                        },
                        {
                            z: 1,
                            type: 'pictorialBar',
                            name: 'TIT',
                            tooltip: {
                                show: false
                            },
                            animation: false,
                            hoverAnimation: false,
                            data: lossqian,
                            symbol: 'path://d=""M936.1,773.6l-10-160.3h20Zm0-264.1-.8,103.8-30.4-42.6s17.4,11.8,8.9-19c0,0,18.8,13.9,8.9-16.8");
            WriteLiteral(@",0-.1,9.6,4.8,13.4-25.4Zm1.7.1L937,613.3l31.1-42.1s-17.6,11.5-8.6-19.1c0,0-19,13.6-8.7-17.1C950.8,535,941.1,539.8,937.8,509.6Zm.5,107.8h-4.4l2.2,132.8Z""',
                            barWidth: 50,
                            itemStyle: {
                                normal: {
                                    barBorderRadius: 50,
                                    color: new echarts.graphic.LinearGradient(
                                        0, 0.25, 0.75, 1,
                                        [{
                                            offset: 0,
                                            color: '#FafF75'
                                        },
                                        {
                                            offset: 1,
                                            color: '#f00'
                                        },
                                        ]
                                    ),
                                    // opacity: .7,");
            WriteLiteral(@"
                                    label: {
                                        show: false
                                    },
                                    shadowColor: '#2D258B',
                                    shadowBlur: 0,
                                    shadowOffsetY: 1,
                                    shadowOffsetX: 1,
                                }
                            },
                        },
                        ]
                    };
                    myFloodEconoCharts.setOption(option);

                }
            })
        })
    }
</script>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
