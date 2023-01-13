using Syncfusion.Maui.Calendar;

namespace ChangeSelectedDate
{
    public class CalendarBehavior : Behavior<ContentPage>
    {
        private SfCalendar calendar;
        private Button buttton;

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);

            this.calendar = bindable.FindByName<SfCalendar>("calendar");
            this.buttton = bindable.FindByName<Button>("button");
            this.buttton.Clicked += Buttton_Clicked;
        }

        private void Buttton_Clicked(object sender, EventArgs e)
        {
            this.calendar.SelectedDate = this.calendar.DisplayDate.AddDays(5);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.buttton != null)
            {
                this.buttton.Clicked -= Buttton_Clicked;
            }

            this.buttton = null;
            this.calendar = null;
        }
    }
}
