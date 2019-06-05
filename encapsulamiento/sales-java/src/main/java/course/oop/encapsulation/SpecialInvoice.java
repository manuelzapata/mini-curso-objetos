package course.oop.encapsulation;

import java.math.BigDecimal;

public class SpecialInvoice extends Invoice {

    public void specialMethod() {
        this.addItem(new InvoiceItem("aaaa", new BigDecimal(1)));
    }

}
