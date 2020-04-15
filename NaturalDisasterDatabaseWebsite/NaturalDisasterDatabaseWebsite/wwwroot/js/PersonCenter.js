//菜单：左菜单右内容
var lis = document.getElementById("ul1").getElementsByTagName("li");
//var divs = document.getElementById("content").getElementsByTagName("div");
var divs = document.getElementById("content").getElementsByClassName("tab");
for (var i = 0; i < lis.length; i++) {
    lis[i].index = i;
    var last = lis[i].index;
    lis[i].onclick = function () {
        for (var j = 0; j < lis.length; j++) {
            lis[j].className = "";
        }
        this.className = "hover";
        for (var i = 0; i < divs.length; i++) {
            divs[i].style.display = "none";
        }
        divs[this.index].style.display = "block";
    }
}
//弹框
function Show() {
    document.getElementById('shade').classList.remove('hide');
    document.getElementById('modal').classList.remove('hide');
}
function Hide() {
    document.getElementById('shade').classList.add('hide');
    document.getElementById('modal').classList.add('hide');
}
//点击此处上传图像
$(document).ready(function () {
    $('#my-img').click(function () {
        $('#imgupload').click();
    });
});
//下面用于图片上传预览功能：修改头像
function setImagePreview() {
    var docObj = document.getElementById("imgupload");
    var imgObjPreview = document.getElementById("previewimg");
    var fileUpload = $("#imgupload").get(0);//获得第一个files的名称和值
    var files = fileUpload.files;//获取文件信息
    var data = new FormData();//通过FormData构造函数创建一个空对象
    if (docObj.files && docObj.files[0]) {
        //火狐下，直接设img属性
        imgObjPreview.style.display = 'block';
        imgObjPreview.style.width = '212px';
        imgObjPreview.style.height = '200px';

        //火狐7以上版本不能用上面的getAsDataURL()方式获取，需要一下方式
        imgObjPreview.src = window.URL.createObjectURL(docObj.files[0]);

        for (var i = 0; i < files.length; i++) {
            data.append(files[i].name, files[i]);//通过append方法追加数据
        }
        $.ajax({
            type: "post",
            url: "/Home/UploadFiles",
            contentType: false,//不要去设置Content-Type请求头
            processData: false,//不要去处理发送的数据
            data: data,
            success: function (data) {
                //document.getElementById('textfield').value = docObj.files[0].name;
                document.getElementById('textfield').value = data.fName;
                //alert(data.message);
                console.log(data.userId);
            },
            error: function () {
                alert("上传文件出现错误！");
            }
        });
    }
    else {
        //IE下，使用滤镜
        docObj.select();
        var imgSrc = document.selection.createRange().text;
        var localImagId = document.getElementById("localImag");
        //必须设置初始大小
        localImagId.style.width = "212px";
        localImagId.style.height = "200px";
        //图片异常的捕捉，防止用户修改后缀来伪造图片
        try {
            localImagId.style.filter = "progid:DXImageTransform.Microsoft.AlphaImageLoader(sizingMethod=scale)";
            localImagId.filters.item("DXImageTransform.Microsoft.AlphaImageLoader").src = imgSrc;
        }
        catch (e) {
            alert("您上传的图片格式不正确，请重新选择!");
            return false;
        }
        document.selection.empty();
    }
    return true;
}
//修改个人资料
function xgzl1() {
    var obj1 = document.getElementById('xiugaiziliao');
    var obj2 = document.getElementById('submitxgzl');
    obj1.style.display = 'none';
    obj2.style.display = 'block';
}
function xgzl2() {
    var obj1 = document.getElementById('xiugaiziliao');
    var obj2 = document.getElementById('submitxgzl');
    obj2.style.display = 'none';
    obj1.style.display = 'block';
}
//眨眼闭眼：明暗文密码
$('.see-passwordold').click(function () {
    $('.oldpassword').toggle();
    if ($('#oldpassword').attr('type') == 'password') {
        $('#oldpassword').attr('type', 'text');
        $('#oldpassword .see-password-icon').style.display = "inline-block";
    } else {
        $('#oldpassword').attr('type', 'password');
        $('#oldpassword .no-see-password-icon').style.display = "none";
    }
});
$('.see-passwordnew').click(function () {
    $('.newpassword').toggle();
    if ($('#newpassword').attr('type') == 'password') {
        $('#newpassword').attr('type', 'text');
        $('#newpassword .see-password-icon').style.display = "inline-block";
    } else {
        $('#newpassword').attr('type', 'password');
        $('#newpassword>.no-see-password-icon').style.display = "none";
    }
});
$('.see-passwordqr').click(function () {
    $('.qrpassword').toggle();
    if ($('#qrpassword').attr('type') == 'password') {
        $('#qrpassword').attr('type', 'text');
        $('#qrpassword .see-password-icon').style.display = "inline-block";
    } else {
        $('#qrpassword').attr('type', 'password');
        $('#qrpassword .no-see-password-icon').style.display = "none";
    }
});
function changeBtnable() {
    var oldval = document.getElementById('oldpassword').value;
    var newval = document.getElementById('newpassword').value;
    var qrval = document.getElementById('qrpassword').value;
    //console.log(oldval, newval, qrval);
    if (oldval && newval && qrval) {
        $('.submt').show();
        $('.noable').hide();
    } else {
        $('.noable').show();
        $('.submt').hide();
    }
}
//显示密码
$(document).ready(function () {
    var $btn = $("#showPas");
    var btn = $btn.get(0);
    $btn.click(function () {
        if (btn.checked) {
            $(".pass").attr("type", "");
        } else {
            $(".pass").attr("type", "password");
        }
    });
})
//原密码匹配
$("#oldpassword").blur(function () {
    var pwd = $("#oldpassword").val();
    if (pwd) {
        $.ajax({
            type: "post",
            url: "/PersonCenter/VerifyPwd",
            data: {
                "password": pwd,
            },
            success: function (e) {
                //console.log(e.message);
                if (e.message) {
                    document.getElementById("errormsg").innerText = e.message;
                } else {
                    document.getElementById('errormsg').innerText = " ";
                }
            }
        });
    }
})
//新密码及确认密码
function ComparePwd() {
    var newPwd = document.getElementById("newpassword").value;
    var ConfirmPwd = document.getElementById("qrpassword").value;
    if (newPwd == ConfirmPwd) {
        return true;
    } else {
        document.getElementById('errormsg').innerText = "两次密码不匹配";
        return false;
    }
}
//我的文章：全部、已发布、待审核、不通过
$(function () {
    $(".navItem li").click(function () {//获取点击事件的对象
        var divShow = $(".contentessay").children('.list');//获取要显示或隐藏的对象
        if (!$(this).hasClass('selected')) {//判断当前对象是否被选中，如果没选中的话进入if循环
            var index = $(this).index();//获取当前对象的索引
            $(this).addClass('selected').siblings('li').removeClass('selected');//当前对象添加选中样式并且其同胞移除选中样式；
            $(divShow[index]).show();//索引对应的div块显示
            $(divShow[index]).siblings('.list').hide();//索引对应的div块的同胞隐藏
        }
        $('.nav-link').bind('click', function () {
            $('.nav-link').removeClass('navactive');
            $(this).addClass('navactive');
        });
    });
});
//我的评论：我的文章评论、我发表的评论切换
$(document).ready(function () {
    $(".comment-nav-tabs .comment-nav-item").click(function () {
        var order = $(".comment-nav-tabs .comment-nav-item").index(this);//获取点击之后返回当前a标签index的值
        $(".con" + order).show().siblings("div").hide();//显示class中con加上返回值所对应的DIV
        $('.comment-nav-item').removeClass('activecomment');
        $(this).addClass('activecomment');
    });
})
