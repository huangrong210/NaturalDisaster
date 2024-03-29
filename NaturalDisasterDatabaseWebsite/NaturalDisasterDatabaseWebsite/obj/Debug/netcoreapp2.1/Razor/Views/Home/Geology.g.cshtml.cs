#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Home\Geology.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef0ff65cf33311535ea44fc1e8c7c9a4d46f2122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Geology), @"mvc.1.0.view", @"/Views/Home/Geology.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Geology.cshtml", typeof(AspNetCore.Views_Home_Geology))]
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
#line 1 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Home\Geology.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef0ff65cf33311535ea44fc1e8c7c9a4d46f2122", @"/Views/Home/Geology.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Geology : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 62, true);
            WriteLiteral("<div id=\"geology\" style=\"width: 100%; height: 402px;\"></div>\r\n");
            EndContext();
#line 3 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Home\Geology.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(133, 19659, true);
            WriteLiteral(@"    <script type=""text/javascript"">
        var myGeologyCharts = echarts.init(document.getElementById('geology'));
        myGeologyCharts.clear();//用于清除已存在的内容
        myGeologyCharts.showLoading();
        $(document).ready(function () {
            $.ajax({
                type: ""get"",
                url: ""/Home/GetGeologicalCharts"",
                dataType: 'json',
                data: {},
                cache: false,
                success: function (res) {
                    //console.log(res);
                    var gyears = [], gtoccurnum = [], gcasualtynum = [], gloss = [], gprojectnum = [], ginvest = [], garea = [];
                    for (var g = 0; g < res.geologylist.length; g++) {
                        gyears[g] = res.geologylist[g].gYears;
                        gtoccurnum[g] = res.geologylist[g].gTOccurNumbers;
                        gcasualtynum[g] = res.geologylist[g].gCasualtiesNumbers;
                        gloss[g] = res.geologylist[g].gEconomicLosses;
   ");
            WriteLiteral(@"                     gprojectnum[g] = res.geologylist[g].gCProjectNumbers;
                        ginvest[g] = res.geologylist[g].gControlInvest;
                        garea[g] = res.geologylist[g].gZhiliArea;
                    }
                    var xaxis = ['人员伤亡(人)', '发生起数(次)', '经济损失(万元)', '防治项目数(个)', '防治投资(万元)', '治理面积(千公顷)'];
                    var occurnum = [], deadnum = [], loss = [], proj = [], invest = [], area = [];
                    for (var gg = 0; gg < gyears.length; gg++) {
                        deadnum[gg] = [xaxis[0], gyears[gg], gcasualtynum[gg]];
                        occurnum[gg] = [xaxis[1], gyears[gg], gtoccurnum[gg]];
                        loss[gg] = [xaxis[2], gyears[gg], gloss[gg]];
                        proj[gg] = [xaxis[3], gyears[gg], gprojectnum[gg]];
                        invest[gg] = [xaxis[4], gyears[gg], ginvest[gg]];
                        area[gg] = [xaxis[5], gyears[gg], garea[gg]];
                    }

                    myGeologyChar");
            WriteLiteral(@"ts.hideLoading();

                    option = {
                        color: ['#fec42c', ""#315C94"", ""#497FB6"", ""#6F8FCF"", '#dd4444', '#80F1BE', ""#7AA0BB"", ""#9FBEDD"",
                            ""#BCD4E1"", ""#00ADD0"", ""#FFA12F"", ""#B62AFF"", ""#604BFF"", ""#6E35FF"", ""#002AFF"", ""#20C0F4"",
                            ""#95F300"", ""#04FDB8"", ""#AF5AFF""
                        ],
                        //backgroundColor: '#170AA2',
                        //backgroundColor: '#211b6a',
                        backgroundColor: {
                            type: 'linear',
                            x: 0,                 // 左上角x
                            y: 0,                 // 左上角y
                            x2: 0,                // 右下角x
                            y2: 1,                // 右下角y
                            colorStops: [{
                                offset: 0, color: 'rgba(23,10,162,0.95)' // 0% 处的颜色
                            }, {
                                offset: 1, col");
            WriteLiteral(@"or: 'rgba(23,10,162,0.82)' // 100% 处的颜色
                            }],
                            global: false // 缺省为 false
                        },
                        textStyle: {
                            color: '#fff',

                        },
                        tooltip: {
                            trigger: 'axis',
                            padding: 5,
                            backgroundColor: '#222',
                            borderColor: '#777',
                            borderWidth: 1,
                            axisPointer: {
                                type: 'none',
                                label: {
                                    backgroundColor: '#6a7985'
                                },
                                lineStyle: {
                                    type: 'dashed',
                                    width: 2,
                                    color: '#4B941A'
                                },
             ");
            WriteLiteral(@"                   animation: true
                            },
                            formatter: function (e) {
                                //console.log(e)
                                var str = '<div style=""border-bottom: 1px solid rgba(255,255,255,.3); font-size: 18px;padding-bottom: 7px;margin-bottom: 7px; text-align:center;"">' + e[0].name + '</div>';
                                for (var q = 0; q < e.length; q++) {
                                    str += e[q].value[1] + ""年"" + ""："" + '<span>&nbsp;&nbsp;</span>' + e[q].value[2] + '<br />';
                                }
                                return str;
                            },
                        },
                        legend: {
                            show: true,
                            data: xaxis,
                            orient: 'horizontal', // 'vertical'
                            x: 'center', // 'center' | 'left' | {number},
                            y: 'top',
           ");
            WriteLiteral(@"                 top: '1%',
                            itemGap: 25,
                            textStyle: {
                                color: '#fff'
                            },
                        },
                        grid: {
                            left: '2%',
                            right: '3%',
                            bottom: '2%',
                            top: '10%',
                            containLabel: true
                        },
                        yAxis: {
                            data: gyears,
                            //data: [],
                            //name:'年',
                            splitLine: {
                                //show: true,
                                show: false,
                                lineStyle: {
                                    type: 'doted',
                                    color: ['#666'],
                                }
                            },
               ");
            WriteLiteral(@"             axisLine: {
                                //show: true,
                                show: false,
                                lineStyle: {
                                    color: '#fff'
                                }
                            },
                            axisTick: {
                                show: false
                            },
                            axisLabel: {
                                formatter: function () {
                                    return '';
                                }
                            }
                        },
                        toolbox: {
                            showTitle: false,
                            feature: {
                                dataView: { //数据视图
                                    show: true,
                                    readOnly: false,
                                    lang: ['', '关闭', '导出Excel'],
                                    b");
            WriteLiteral(@"uttonColor: '#30C76C',
                                    iconStyle: {
                                        borderColor: '#fff'
                                    },
                                    emphasis: {
                                        iconStyle: {
                                            borderColor: '#f00'
                                        },
                                    },
                                    contentToOption: function (opts) {
                                        //console.log(opts)
                                        $.noConflict(); //请务必加上这一句，否则无法下载excel
                                        $(""#tableExcel_Geology"").table2excel({ //通过id即tableExcel_Day
                                            exclude: "".noExl"", //过滤位置的 css 类名：有class=""noExl""的行不被导出
                                            name: ""表格-"" + new Date().getTime(),
                                            filename: ""广西地质灾害"" + new Date().getTime() + "".xls"", //文件名");
            WriteLiteral(@"称
                                            exclude_img: true,
                                            exclude_links: true,
                                            exclude_inputs: true
                                        });
                                    },
                                    optionToContent: function (opt) {
                                        //console.log(opt)
                                        var axisData = opt.yAxis[0].data; // 坐标数据
                                        var series = opt.series; // 折线图数据
                                        var tdHeaders = '<td></td><td>年份</td>'; // 表头第一列
                                        for (var k = 0; k < series.length - 1; k++) {
                                            tdHeaders += '<td style=""padding:0px 2px;"">' + series[k].name + '</td>'; //组装表头

                                        }
                                        var table = '<div style=""overflow-y:auto;height: 100%;width:100%");
            WriteLiteral(@";""><table id=""tableExcel_Geology"" class=""table-bordered table-striped"" style=""text-align:center; border-collapse:collapse; margin:0 auto; text-align:center;"" border=""1"" ><tbody><tr>' + tdHeaders + '</tr>';
                                        var tdBodys = ''; // 表数据
                                        for (var i = 0, l = axisData.length; i < l; i++) {
                                            for (var j = 0; j < series.length - 1; j++) {
                                                var temp = series[j].data[i];
                                                if (temp != null && temp != undefined) {
                                                    tdBodys += '<td>' + series[j].data[i][2] + '</td>'; //组装表数据
                                                } else {
                                                    tdBodys += '<td></td>';
                                                }
                                            }
                                            table += ");
            WriteLiteral(@"'<tr><td style=""padding:0 6px;"">' + (i + 1) + '</td><td style=""padding: 0 10px"">' + axisData[i] + '</td>' + tdBodys + '</tr>';
                                            tdBodys = '';
                                        }
                                        table += '</tbody></table></div>';
                                        return table;
                                    },
                                },
                                saveAsImage: {
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
                              ");
            WriteLiteral(@"  show: true,
                                textStyle: {
                                    color: '#fff'
                                }
                            }
                        },
                        xAxis: {
                            data: xaxis,
                            axisLine: {
                                show: true,
                                lineStyle: {
                                    color: '#fff',
                                },
                            },
                            axisLabel: {
                                interval: 0
                            }
                        },
                        series: [
                            {
                                name: '人员伤亡(人)',
                                type: 'scatter',
                                symbol: 'circle',//'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (dat");
            WriteLiteral(@"a) {
                                    return Math.sqrt(data[2]) * 2;
                                },
                                symbolOffset: ['-200%', '0%'],
                                label: {
                                    emphasis: {
                                        show: true,
                                        formatter: function (param) {
                                            return param.data[2];
                                        },
                                        position: 'inside'
                                    }
                                },
                                itemStyle: {
                                    normal: {
                                        color: '#C94C15'
                                    }
                                },
                                data: deadnum
                            },
                            {
                                name: '发生起数(次)',
   ");
            WriteLiteral(@"                             type: 'scatter',
                                symbol: 'diamond',//'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (data) {
                                    return Math.sqrt(data[2]) * 1;
                                },
                                symbolOffset: ['-200%', '0%'],
                                label: {
                                    emphasis: {
                                        show: true,
                                        formatter: function (param) {
                                            return param.data[2];
                                        },
                                        position: 'inside'
                                    }
                                },
                                itemStyle: {
                                    normal: {
                                        color: '#B62AFF'
            ");
            WriteLiteral(@"                        }
                                },
                                data: occurnum
                            },

                            {
                                name: '经济损失(万元)',
                                type: 'scatter',
                                symbol: 'circle',//'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (data) {
                                    return Math.sqrt(data[2]) * 0.5;
                                },
                                symbolOffset: ['-200%', '0%'],
                                label: {
                                    emphasis: {
                                        show: true,
                                        formatter: function (param) {
                                            return param.data[2];
                                        },
                                        position: 'inside'
       ");
            WriteLiteral(@"                             }
                                },
                                itemStyle: {
                                    normal: {
                                        color: '#A18F1D'
                                    }
                                },
                                data: loss
                            },
                            {
                                name: '防治项目数(个)',
                                type: 'scatter',
                                symbol: 'rect',//'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (data) {
                                    return Math.sqrt(data[2]) * 1;
                                },
                                symbolOffset: ['-200%', '0%'],
                                label: {
                                    emphasis: {
                                        show: true,
                            ");
            WriteLiteral(@"            formatter: function (param) {
                                            return param.data[2];
                                        },
                                        position: 'inside'
                                    }
                                },
                                itemStyle: {
                                    normal: {
                                        color: '#17885C'
                                    }
                                },
                                data: proj
                            },
                            {
                                name: '防治投资(万元)',
                                type: 'scatter',
                                symbol: 'circle',//'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (data) {
                                    return Math.sqrt(data[2]) * 0.15;
                                },
          ");
            WriteLiteral(@"                      symbolOffset: ['-300%', '0%'],
                                label: {
                                    emphasis: {
                                        show: true,
                                        formatter: function (param) {
                                            return param.data[2];
                                        },
                                        position: 'inside'
                                    }
                                },
                                itemStyle: {
                                    normal: {
                                        color: '#2769CF'
                                    }
                                },
                                data: invest
                            },
                            {
                                name: '治理面积(千公顷)',
                                type: 'scatter',
                                symbol: 'triangle',//'circle', 'rect', '");
            WriteLiteral(@"roundRect', 'triangle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (data) {
                                    return Math.sqrt(data[2]) * 0.18;
                                },
                                symbolOffset: ['-100%', '-25%'],
                                label: {
                                    emphasis: {
                                        show: true,
                                        formatter: function (param) {
                                            return param.data[2];
                                        },
                                        position: 'insideBottom'
                                    }
                                },
                                itemStyle: {
                                    normal: {
                                        color: '#509820'
                                    }
                                },
                                data: area
");
            WriteLiteral("                            },\r\n                        ]\r\n                    };\r\n                    myGeologyCharts.setOption(option);\r\n\r\n                }\r\n            })\r\n        })\r\n    </script>\r\n");
            EndContext();
#line 378 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Home\Geology.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(19804, 14976, true);
            WriteLiteral(@"    <script type=""text/javascript"">
        var myGeologyCharts = echarts.init(document.getElementById('geology'));
        myGeologyCharts.clear();//用于清除已存在的内容
        myGeologyCharts.showLoading();
        $(document).ready(function () {
            $.ajax({
                type: ""get"",
                url: ""/Home/GetGeologicalCharts"",
                dataType: 'json',
                data: {},
                cache: false,
                success: function (res) {
                    //console.log(res);
                    var gyears = [], gtoccurnum = [], gcasualtynum = [], gloss = [], gprojectnum = [], ginvest = [], garea = [];
                    for (var g = 0; g < res.geologylist.length; g++) {
                        gyears[g] = res.geologylist[g].gYears;
                        gtoccurnum[g] = res.geologylist[g].gTOccurNumbers;
                        gcasualtynum[g] = res.geologylist[g].gCasualtiesNumbers;
                        gloss[g] = res.geologylist[g].gEconomicLosses;
   ");
            WriteLiteral(@"                     gprojectnum[g] = res.geologylist[g].gCProjectNumbers;
                        ginvest[g] = res.geologylist[g].gControlInvest;
                        garea[g] = res.geologylist[g].gZhiliArea;
                    }
                    var xaxis = ['人员伤亡(人)', '发生起数(次)', '经济损失(万元)', '防治项目数(个)', '防治投资(万元)', '治理面积(千公顷)'];
                    var occurnum = [], deadnum = [], loss = [], proj = [], invest = [], area = [];
                    for (var gg = 0; gg < gyears.length; gg++) {
                        deadnum[gg] = [xaxis[0], gyears[gg], gcasualtynum[gg]];
                        occurnum[gg] = [xaxis[1], gyears[gg], gtoccurnum[gg]];
                        loss[gg] = [xaxis[2], gyears[gg], gloss[gg]];
                        proj[gg] = [xaxis[3], gyears[gg], gprojectnum[gg]];
                        invest[gg] = [xaxis[4], gyears[gg], ginvest[gg]];
                        area[gg] = [xaxis[5], gyears[gg], garea[gg]];
                    }

                    myGeologyChar");
            WriteLiteral(@"ts.hideLoading();

                    option = {
                        color: ['#fec42c', ""#315C94"", ""#497FB6"", ""#6F8FCF"", '#dd4444', '#80F1BE', ""#7AA0BB"", ""#9FBEDD"",
                            ""#BCD4E1"", ""#00ADD0"", ""#FFA12F"", ""#B62AFF"", ""#604BFF"", ""#6E35FF"", ""#002AFF"", ""#20C0F4"",
                            ""#95F300"", ""#04FDB8"", ""#AF5AFF""
                        ],
                        //backgroundColor: '#170AA2',
                        //backgroundColor: '#211b6a',
                        backgroundColor: {
                            type: 'linear',
                            x: 0,                 // 左上角x
                            y: 0,                 // 左上角y
                            x2: 0,                // 右下角x
                            y2: 1,                // 右下角y
                            colorStops: [{
                                offset: 0, color: 'rgba(23,10,162,0.95)' // 0% 处的颜色
                            }, {
                                offset: 1, col");
            WriteLiteral(@"or: 'rgba(23,10,162,0.82)' // 100% 处的颜色
                            }],
                            global: false // 缺省为 false
                        },
                        textStyle: {
                            color: '#fff',

                        },
                        tooltip: {
                            trigger: 'axis',
                            padding: 5,
                            backgroundColor: '#222',
                            borderColor: '#777',
                            borderWidth: 1,
                            axisPointer: {
                                type: 'none',
                                label: {
                                    backgroundColor: '#6a7985'
                                },
                                lineStyle: {
                                    type: 'dashed',
                                    width: 2,
                                    color: '#4B941A'
                                },
             ");
            WriteLiteral(@"                   animation: true
                            },
                            formatter: function (e) {
                                //console.log(e)
                                var str = '<div style=""border-bottom: 1px solid rgba(255,255,255,.3); font-size: 18px;padding-bottom: 7px;margin-bottom: 7px; text-align:center;"">' + e[0].name + '</div>';
                                for (var q = 0; q < e.length; q++) {
                                    str += e[q].value[1] + ""年"" + ""："" + '<span>&nbsp;&nbsp;</span>' + e[q].value[2] + '<br />';
                                }
                                return str;
                            },
                        },
                        legend: {
                            show: true,
                            data: xaxis,
                            orient: 'horizontal', // 'vertical'
                            x: 'center', // 'center' | 'left' | {number},
                            y: 'top',
           ");
            WriteLiteral(@"                 top: '1%',
                            itemGap: 25,
                            textStyle: {
                                color: '#fff'
                            },
                        },
                        grid: {
                            left: '2%',
                            right: '3%',
                            bottom: '2%',
                            top: '10%',
                            containLabel: true
                        },
                        yAxis: {
                            data: gyears,
                            //data: [],
                            //name:'年',
                            splitLine: {
                                //show: true,
                                show: false,
                                lineStyle: {
                                    type: 'doted',
                                    color: ['#666'],
                                }
                            },
               ");
            WriteLiteral(@"             axisLine: {
                                //show: true,
                                show: false,
                                lineStyle: {
                                    color: '#fff'
                                }
                            },
                            axisTick: {
                                show: false
                            },
                            axisLabel: {
                                formatter: function () {
                                    return '';
                                }
                            }
                        },
                        xAxis: {
                            data: xaxis,
                            axisLine: {
                                show: true,
                                lineStyle: {
                                    color: '#fff',
                                },
                            },
                            axisLabel: {
           ");
            WriteLiteral(@"                     interval: 0
                            }
                        },
                        series: [
                            {
                                name: '人员伤亡(人)',
                                type: 'scatter',
                                symbol: 'circle',//'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (data) {
                                    return Math.sqrt(data[2]) * 2;
                                },
                                symbolOffset: ['-200%', '0%'],
                                label: {
                                    emphasis: {
                                        show: true,
                                        formatter: function (param) {
                                            return param.data[2];
                                        },
                                        position: 'inside'
                           ");
            WriteLiteral(@"         }
                                },
                                itemStyle: {
                                    normal: {
                                        color: '#C94C15'
                                    }
                                },
                                data: deadnum
                            },
                            {
                                name: '发生起数(次)',
                                type: 'scatter',
                                symbol: 'diamond',//'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (data) {
                                    return Math.sqrt(data[2]) * 1;
                                },
                                symbolOffset: ['-200%', '0%'],
                                label: {
                                    emphasis: {
                                        show: true,
                                        for");
            WriteLiteral(@"matter: function (param) {
                                            return param.data[2];
                                        },
                                        position: 'inside'
                                    }
                                },
                                itemStyle: {
                                    normal: {
                                        color: '#B62AFF'
                                    }
                                },
                                data: occurnum
                            },

                            {
                                name: '经济损失(万元)',
                                type: 'scatter',
                                symbol: 'circle',//'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (data) {
                                    return Math.sqrt(data[2]) * 0.5;
                                },
                    ");
            WriteLiteral(@"            symbolOffset: ['-200%', '0%'],
                                label: {
                                    emphasis: {
                                        show: true,
                                        formatter: function (param) {
                                            return param.data[2];
                                        },
                                        position: 'inside'
                                    }
                                },
                                itemStyle: {
                                    normal: {
                                        color: '#A18F1D'
                                    }
                                },
                                data: loss
                            },
                            {
                                name: '防治项目数(个)',
                                type: 'scatter',
                                symbol: 'rect',//'circle', 'rect', 'roundRect', 'tria");
            WriteLiteral(@"ngle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (data) {
                                    return Math.sqrt(data[2]) * 1;
                                },
                                symbolOffset: ['-200%', '0%'],
                                label: {
                                    emphasis: {
                                        show: true,
                                        formatter: function (param) {
                                            return param.data[2];
                                        },
                                        position: 'inside'
                                    }
                                },
                                itemStyle: {
                                    normal: {
                                        color: '#17885C'
                                    }
                                },
                                data: proj
                            ");
            WriteLiteral(@"},
                            {
                                name: '防治投资(万元)',
                                type: 'scatter',
                                symbol: 'circle',//'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (data) {
                                    return Math.sqrt(data[2]) * 0.15;
                                },
                                symbolOffset: ['-300%', '0%'],
                                label: {
                                    emphasis: {
                                        show: true,
                                        formatter: function (param) {
                                            return param.data[2];
                                        },
                                        position: 'inside'
                                    }
                                },
                                itemStyle: {
                          ");
            WriteLiteral(@"          normal: {
                                        color: '#2769CF'
                                    }
                                },
                                data: invest
                            },
                            {
                                name: '治理面积(千公顷)',
                                type: 'scatter',
                                symbol: 'triangle',//'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow'
                                symbolSize: function (data) {
                                    return Math.sqrt(data[2]) * 0.18;
                                },
                                symbolOffset: ['-100%', '-25%'],
                                label: {
                                    emphasis: {
                                        show: true,
                                        formatter: function (param) {
                                            return param.data[2];
                  ");
            WriteLiteral(@"                      },
                                        position: 'insideBottom'
                                    }
                                },
                                itemStyle: {
                                    normal: {
                                        color: '#509820'
                                    }
                                },
                                data: area
                            },
                        ]
                    };
                    myGeologyCharts.setOption(option);

                }
            })
        })
    </script>
");
            EndContext();
#line 681 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Home\Geology.cshtml"
}

#line default
#line hidden
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
