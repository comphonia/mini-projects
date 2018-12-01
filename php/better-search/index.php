<?php require_once( 'search.php');
 $varset = false;
  if(isset($_GET[ 'search'])) {
    $searchvar= urlencode($_GET['search']);
   $varset = true;
} 
?>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.1.0/css/all.css" integrity="sha384-lKuwvrZot6UHsBSfcMvOkWwlCMgc0TaWr+30HWe3a4ltaBwTZhyTEggF5tJv8tbt" crossorigin="anonymous">
<div class="container">
    <br />
    <div class="row justify-content-center">
        <div class="col-12 col-md-10 col-lg-8">
            <div class="h1 text-center">Better Search</div>
            <form class="card card-sm" action="" method="get">
                <div class="card-body row no-gutters align-items-center">
                    <div class="col-auto mx-2">
                        <i class="fas fa-search h4 text-body"></i>
                    </div>
                    <!--end of col-->
                    <div class="col">
                        <input class="form-control form-control-lg form-control-borderless" name="search" type="search" placeholder="Search first name and or last name">
                    </div>
                    <!--end of col-->
                    <div class="col-auto mx-2">
                        <button class="btn btn-lg btn-success" type="submit">Search</button>
                    </div>
                    <!--end of col-->
                </div>
            </form>
             
        </div>
 <div class="col-12 col-md-10 col-lg-12" <?php if($varset == false) echo("hidden");?>>
       <label class="m-0 p-0 text-muted ">Showing results for :  <?php if($varset == true) echo($searchvar);?></label>
        <table class="table table-striped mt-5">
            <thead>
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">FirstName</th>
                    <th scope="col">LastName</th>
                    <th scope="col">Email</th>
                    <th scope="col">Gender</th>
                </tr>
            </thead>
            <tbody>
                <?php if($varset == true) searchdb($searchvar);?>
            </tbody>
        </table>
        </div>
        <!--end of col-->
    </div>
</div>