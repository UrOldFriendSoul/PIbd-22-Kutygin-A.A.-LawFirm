﻿@{
    ViewData["Title"] = "Create";
}
< div class= "text-center" >
 
     < h2 class= "display-4" > Создание заказа </ h2 >
     </ div >
     < form method = "post" >
      
          < div class= "row" >
       
               < div class= "col-4" > Документ:</ div >
           
                   < div class= "col-8" >
            
                        < select id = "furniture" name = "furniture" class= "form-control" asp - items = "@(new SelectList(@ViewBag.Furnitures,"Id ", "FurnitureName "))" ></ select >
                        
                                </ div >
                        
                            </ div >
                        
                            < div class= "row" >
                         
                                 < div class= "col-4" > Количество:</ div >
                             
                                     < div class= "col-8" >< input type = "text" name = "count" id = "count" /></ div >
                                     
                                         </ div >
                                     
                                         < div class= "row" >
                                      
                                              < div class= "col-4" > Сумма:</ div >
                                          
                                                  < div class= "col-8" >
                                           
                                                       < input type = "text" id = "sum" name = "sum" readonly= "true" />
                                                  
                                                          </ div >
                                                  
                                                      </ div >
                                                  
                                                      < div class= "row" >
                                                   
                                                           < div class= "col-8" ></ div >
                                                    
                                                            < div class= "col-4" >
                                                     
                                                                 < input type = "submit" value = "Создать" class= "btn btn-primary" />
                                                          
                                                                  </ div >
                                                          
                                                              </ div >
                                                          </ form >
                                                          

                                                          < script >
    $('#furniture').on('change', function() {
    check();
});
    $('#count').on('change', function() {
    check();
});
function check()
{
    var count = $('#count').val();
    var furniture = $('#furniture').val();
    if (count && furniture)
    {
            $.ajax({
        method: "POST",
                url: "/Home/Calc",
                data: { count: count, furniture: furniture },
                success: function(result) {
                    $("#sum").val(result);
            }
        });
        }
    }
</ script > 