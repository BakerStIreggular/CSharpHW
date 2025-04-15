using System;
using static System.Console;


class PhotoDemo
{
    
    static void Main()
    {
  
        Photo stdPhoto = new Photo();
        Photo customPhoto = new Photo();
     
        MattedPhoto mattedPhoto = new MattedPhoto();
        FramedPhoto framedPhoto = new FramedPhoto();

     
        stdPhoto.Width = 8;
       
        stdPhoto.Height = 10;
      
        customPhoto.Width = 8;
    
        customPhoto.Height = 9;
  
        mattedPhoto.Width = 10;

        mattedPhoto.Height = 12;

        mattedPhoto.Color = "white";

        framedPhoto.Width = 8;
     
        framedPhoto.Height = 10;
      
        framedPhoto.Material = "silver";
  
        framedPhoto.Style = "modern";


        WriteLine(stdPhoto.ToString());
        WriteLine(customPhoto.ToString());
        WriteLine(mattedPhoto.ToString());
        WriteLine(framedPhoto.ToString());
    }
}



class Photo
{
   
    private int width;
    private int height;
  
    public int Width
    {
       
        get
        {
            return this.width;
        }
    
        set
        {
            this.width = value;
        }
    }


    public int Height
    {
      
        get
        {
            return this.height;
        }
  
        set
        {
            this.height = value;
        }
    }

 
    protected virtual double Price
    {

        
        get
        {
           
            if (this.Width == 8 && this.Height == 10)
            {
                return 3.99;
            }
          
            else if (this.Width == 10 && this.Height == 12)
            {
                return 5.99;
            }
            
            else
            {
                return 9.99;
            }
        }
    }

    
    public override string ToString()
    {
        
        return this.GetType().Name + ": " + this.Width + " X " + this.Height + " - Price: $" + this.Price;
    }
}


class MattedPhoto : Photo
{
    
    public string Color { get; set; }
  
    protected override double Price
    {
       
        get
        {
           
            return base.Price + 10;
        }
    }
    
    public override string ToString()
    {
        
        return this.GetType().Name + ": " + this.Width + " X " + this.Height + "(" + this.Color + " matting) - Price: $" + this.Price;
    }
}


class FramedPhoto : Photo
{
    
    public string Material { get; set; }
    public string Style { get; set; }
   
    protected override double Price
    {
        
        get
        {
            
            return base.Price + 25;
        }
    }
   
    public override string ToString()
    {
       
        return this.GetType().Name + ": " + this.Width + " X " + this.Height + "(" + this.Style + "," + this.Material + " frame) - Price: $" + this.Price;
    }
}
