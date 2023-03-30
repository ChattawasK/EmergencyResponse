<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmQuestionRespone.aspx.aspx.cs" Inherits="EmergencyResponse.Forms.FrmQuestionRespone_aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="bg-image" style="">

        <div class="container-fluid">
            <div class="div-container">
                <div class="div-container-body">
                    <div class="exem-header">
                        <div class="div-title">
                            <div class="div-logo">
                                <img role="img" title="" aria-hidden="true" aria-label=""
                                    src="../../Img/logo.jpg" height="70" width="163" class="visiable"
                                    style="left: 0px; top: 0px; border: 0px; vertical-align: middle; position: relative;">
                            </div>
                            <div class="text-format-content">
                                <span>แบบทดสอบความรู้ด้านความปลอดภัยสำหรับผู้มาติดต่อ  EXEM FOR VISITOR TRAINING</span>
                            </div>

                        </div>

                        <div class="div-subTitle">
                            <span>ข้อสอบมีทั้งหมด 10 ข้อ คิดเป็น 10 คะแนน ผู้สอบต้องทำให้ผ่านเกิน 8 คะแนนขึ้นไปถึงจะถือว่าผ่าน</span>
                        </div>
                        <div class="div-fa-volume">
                            <button class="button-fa-volume hidden">
                                <i class="fa fa-volume-up" title="โปรแกรมช่วยอ่าน"></i>
                            </button>


                        </div>
                    </div>
                    <div style="display: flex; flex-flow: row-reverse nowrap; align-items: stretch; justify-content: initial; min-height: 6.875rem; font-size: 20px;background-color: #e6eef2;">
                        <div>
                            <span runat="server" id="txtScroe" style="color: #03787c; padding-left: 10px; padding-right: 20px;"></span>
                        </div>
                        <div>คะแนน: </div>


                    </div>
                    <div class="exem-body">
                        <div id="PersonalData">
                            <span><span style="color: red; padding: 5px">*</span>จำเป็น</span>
                            <div class="exem-que">
                                <span style="color: #106ebe; white-space: pre-wrap; font-size: 20px;">Personal Data  /  ข้อมูลส่วนบุคคล</span>
                                <div class="clear-line"></div>
                                <span>Please fill all item to completely /  โปรดกรอกข้อมูลให้ครบถ้วนทุกข้อ</span>

                            </div>

                            <div class="exem-que">
                                <span style="font-family: myK2D-Medium;"><i class="fa fa-youtube-play" aria-hidden="true" style="padding-right: 10px;"></i>โปรดดูวีดีโอให้จบก่อนทำข้อสอบ  Please see the video before to do the exam.<span style="color: red; padding: 5px">*</span></span>
                                <div>
                                    <iframe width="560" height="315" src="https://www.youtube.com/embed/VNep7_5Vme4" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>
                                </div>
                                <div>
                                    <input type="radio" id="watchComplete" name="watchYoutube" value="True" <% if(res.WatchYoutube == "True") { %>checked<% } %> readonly="true" disabled />
                                    <label for="watchComplete">ดูเรียบร้อย / Watch complete</label>
                                </div>

                                <div>
                                    <input type="radio" id="notComplete" name="watchYoutube" value="False" <% if(res.WatchYoutube == "False") { %>checked<% } %>  readonly="true" disabled>
                                    <label for="notComplete">ยังไม่แล้วเสร็จ / Not complete</label>
                                </div>
                                <label class="n-error" for="watchYoutube">ต้องใส่ข้อมูลนี้</label>

                            </div>

                            <div class="exem-que">
                                <span style="font-family: myK2D-Medium;"><i class="fa fa-calendar" aria-hidden="true" style="padding-right: 10px;"></i>Date for testing / วันที่ทำแบบทดสอบ<span style="color: red; padding: 5px">*</span></span>
                                <div class="input-group " style="padding-bottom: 10px; padding-right: 10px;">
                                    <input type="text" class="form-control" id='as_of_date_form' value="<%= res.AsOfDate %>"  readonly="true" />
                                    <div class="input-group-addon">
                                        <span class="glyphicon glyphicon-th"></span>
                                    </div>
                                </div>
                                <label class="n-error" for="as_of_date_form">ต้องใส่ข้อมูลนี้</label>
                            </div>
                            <div class="exem-que">
                                <span style="font-family: myK2D-Medium;"><i class="fa fa-phone" aria-hidden="true" style="padding-right: 10px;"></i>Phone / หมายเลขโทรศัพท์<span style="color: red; padding: 5px">*</span></span>
                                <div style="line-height: 5px;"></div>
                                <span>โปรดระบุให้ถูกต้อง</span>
                                <div style="padding-bottom: 10px; padding-right: 10px;">
                                    <input class="form-control" type="tel" placeholder="ใส่คำตอบ" id="phone" value="<%= res.Phone %>" readonly="true">
                                    <label class="n-error" for="phone">โปรดระบุให้ถูกต้อง</label>
                                </div>
                            </div>
                            <div class="exem-que">
                                <span style="font-family: myK2D-Medium;"><i class="fa fa-credit-card" aria-hidden="true" style="padding-right: 10px;"></i>Name - Surname / ชื่อ-นามสกุล<span style="color: red; padding: 5px">*</span></span>
                                <div style="line-height: 5px;"></div>
                                <span>โปรดสะกดชื่อ นามสกุลของท่านให้ถูกต้อง</span>
                                <div style="padding-bottom: 10px; padding-right: 10px;">
                                    <input class="form-control" type="text" placeholder="ใส่คำตอบ" id="fullname" value="<%= res.FullName %>" readonly="true">
                                    <label class="n-error" for="fullname">ต้องใส่ข้อมูลนี้</label>
                                </div>
                            </div>
                            <div class="exem-que">
                                <span style="font-family: myK2D-Medium;"><i class="fa fa-building" aria-hidden="true" style="padding-right: 10px;"></i>YourCompany name / ชื่อบริษัทท่าน<span style="color: red; padding: 5px">*</span></span>
                                <div style="line-height: 5px;"></div>
                                <span>ใส่ชื่อบริษัทท่านให้ถูกต้อง กรณีผู้รับเหมาช่วงต่อให้ใส่บริษัทฯเจ้าของงานท่าน</span>
                                <div style="padding-bottom: 10px; padding-right: 10px;">
                                    <input class="form-control" type="text" placeholder="ใส่คำตอบ" id="company" value="<%= res.Companay %>" readonly="true">
                                    <label class="n-error" for="company">ต้องใส่ข้อมูลนี้</label>
                                </div>
                            </div>

                            

                        </div>
                        <div id="ExamAfterTraining">
                            <span><span style="color: red; padding: 5px">*</span>จำเป็น</span>
                            <div class="exem-que">
                                <span style="color: #106ebe; white-space: pre-wrap; font-size: 20px;">Exam after training /  แบบทดสอบหลังการฝึกอบรม</span>
                                <div class="clear-line"></div>
                                <div style="line-height: 20px;">
                                    (คำชี้แจงแบบทดสอบมีทั้งหมด 10 ข้อ โปรดทำเครื่องหมาย หน้าข้อความที่ท่านคิดว่าคำถามนั้นถูกต้อง หรือทำเครื่องหมาย หน้าข้อความที่ท่านคิดว่าคำถามนั้นผิด  เกณฑ์ผ่านต้องได้คะแนนมากกว่าหรือเท่ากับ 8 คะแนนจึงจะผ่านการฝึกอบรม)
                                </div>
                                <b><u>Please answer all questions below / Correct, X Incorrect</u></b>

                            </div>

                            <% foreach (var item in res.Excems)
                                { %>

                            <div class="exem-que" style="padding: 5px; margin-top: 20px;">
                                <% if (item.IsCorrect == "1")
                                    { %>
                                <div class="ans-corret">
                                    <span><i class="fa fa-check" aria-hidden="true" style="padding-right: 10px;"></i>ถูกต้อง 1/1 คะแนน</span>
                                </div>
                                <% }
                                    else
                                    { %>
                                <div class="ans-worng">
                                    <span><i class="fa fa-times" aria-hidden="true" style="padding-right: 10px;"></i>ไม่ถูกต้อง 0/1 คะแนน</span>
                                </div>
                                <% }%>

                                <div style="line-height: 20px;">
                                    <span style="padding-right: 5px;"><b><%= item.No %>.</b></span> <%= item.QuestionTH %><span style="color: red; padding: 5px">*</span><span style="color: blue;">(1 คะแนน)</span>
                                </div>
                                <div style="line-height: 20px; padding-top: 10px;"><b><%= item.QuestionEN %></b></div>


                                <div style="padding-top: 10px">
                                    <% foreach (var choice in item.Choices)
                                        { %>

                                    <div style="line-height: 20px;">
                                        <input type="radio" id="<%= choice.Id %>" name="<%= item.Name %>" value="<%= choice.Value %>"  <% if(item.UserChoose == choice.Value) { %>checked<% } %>>
                                        <label for="<%= item.Name %>"><%= choice.Text %></label>
                                        <% if (item.Answer == choice.Value)
                                        { %>
                                        <i class="fa fa-check" aria-hidden="true" style="padding-left: 10px; color: #13a10e;"></i>
                                        <% } %>
                                    </div>
                                    <% } %>
                                </div>

                            </div>
                            <% } %>
                        </div>
                    </div>

                </div>


            </div>
        </div>

    </div>


</asp:Content>
