package course.oop.encapsulation.other;

import course.oop.encapsulation.Invoice;

import java.math.BigDecimal;

public class AnotherInvoice extends Invoice {

    void myMethod() {
        BigDecimal amount = calculateTotal();
        this.addItem("ab", new BigDecimal(1));
        System.out.println(amount);
        //this.items;
    }

}
